using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer.Matching
{
    public class Cascader : IMatcherExtra
    {
        public event EventHandler Progress;

        public Cascader(IMatcher matcher)
        {
            _matcher = matcher;

            // Don't report individual chamfer progress because
            // cascading effect is not deterministic
            // _matcher.Progress += new EventHandler(OnProgress());
        }

        public IMatcher Matcher
        {
            get
            {
                return _matcher;
            }
            set
            {
                _matcher = value;
                
            }
        }

        public double Threshold
        {
            get
            {
                return _threshold;
            }
            set
            {
                _threshold = value;
            }
        }

        public int QualityCount
        {
            get
            {
                return _qualityCount;
            }
            set
            {
                _qualityCount = value;
            }
        }

        public int SkipsPerQuality
        {
            get
            {
                return _skipsPerQuality;
            }
            set
            {
                _skipsPerQuality = value;
            }
        }

        public double GetScore(Image image1, Image image2)
        {
            // Report progress
            OnProgress();

            if (image1 == null || image2 == null)
            {
                return double.PositiveInfinity;
            }

            // Increase in quality (0 = highest)
            for (int quality = _qualityCount - 1; quality >= 0; quality--)
            {
                Image newImage1 = GetNewImage(image1, quality);
                Image newImage2 = GetNewImage(image2, quality);

                double score = _matcher.GetScore(newImage1, newImage2);

                if (score > _threshold)
                {
                    return score;
                }
            }

            return _matcher.GetScore(image1, image2);
        }

        public int CountSteps()
        {
            return 1;
        }

        private void OnProgress()
        {
            if (Progress != null)
            {
                Progress(this, new EventArgs());
            }
        }

        private Image GetNewImage(Image image, int quality)
        {
            if (image == null)
            {
                return null;
            }

            Bitmap bmp = image as Bitmap;
            if (bmp == null)
            {
                throw new Exception("Image must be a Bitmap.");
            }

            int step = quality * _skipsPerQuality + 1;

            int width = bmp.Width;
            int height = bmp.Height;

            int newWidth = (width - 1) / step + 1;
            int newHeight = (height - 1) / step + 1;

            Bitmap newBmp = new Bitmap(newWidth, newHeight);

            // Lock bitmap data
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            // Lock new bitmap data
            Rectangle newRect = new Rectangle(0, 0, newWidth, newHeight);
            BitmapData newBmpData = newBmp.LockBits(newRect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            // Get some image constants
            int bpp = 4;
            int newBpp = 4;
            int stride = bmpData.Stride;
            int newStride = newBmpData.Stride;

            int i, j, newI, newJ;

            unsafe
            {
                // Get pointers to origin of bitmaps
                byte* bmpPtrOrigin = (byte*)bmpData.Scan0;
                byte* newBmpPtrOrigin = (byte*)newBmpData.Scan0;

                // Declare pointers to pixel location of bitmaps
                byte* bmpPtr = null;
                byte* newBmpPtr = null;

                for (newJ = 0; newJ < newHeight; newJ++)
                {
                    j = newJ * step;

                    for (newI = 0; newI < newWidth; newI++)
                    {
                        i = newI * step;

                        bmpPtr = bmpPtrOrigin + (i * bpp) + (j * stride);
                        newBmpPtr = newBmpPtrOrigin + (newI * newBpp) + (newJ * newStride);

                        newBmpPtr[0] = bmpPtr[0];
                        newBmpPtr[1] = bmpPtr[1];
                        newBmpPtr[2] = bmpPtr[2];
                        newBmpPtr[3] = bmpPtr[3];
                    }
                }
            }

            // Unlock image data
            bmp.UnlockBits(bmpData);
            newBmp.UnlockBits(newBmpData);

            return newBmp;
        }

        private unsafe byte* GetImagePtr(byte* originPtr, int i, int j,
            int width, int height, int bpp, int stride)
        {
            // Return null if (i, j) is out of bounds
            if ((i < 0) || (j < 0) || (i >= width) || (j >= height))
            {
                return null;
            }

            // Return pointer to corresponding pixel
            return originPtr + (i * bpp) + (j * stride);
        }

        private IMatcher _matcher = null;

        private double _threshold = 1.5;

        private int _qualityCount = 5;
        private int _skipsPerQuality = 2;
    }
}
