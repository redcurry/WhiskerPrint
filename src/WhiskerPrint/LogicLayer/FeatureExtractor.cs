using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer
{
    public class FeatureExtractor
    {
        public FeatureExtractor()
        {
            DefineOuterFeaturePath();
            DefineInnerFeaturePath();
        }

        public int Smoothing
        {
            get
            {
                return smoothing;
            }
            set
            {
                smoothing = value;
            }
        }

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public int Threshold
        {
            get
            {
                return threshold;
            }
            set
            {
                threshold = value;
            }
        }

        public Bitmap GetFeature(Bitmap pbPhoto, Point[] pbAnchors)
        {
            // Create a copy of the input image
            Bitmap pbPhotoCopy = GetStandardizedBmp(pbPhoto, pbAnchors);

            // Get a cropped copy of the standardized image
            Bitmap pbPhotoCropped = GetCroppedBmp(pbPhotoCopy);

            // Cutout everything but the specified region (path)
            ClipBmp(pbPhotoCropped, outerPath);

            // Improve brightness/contrast of image
            //histogramCorrection.Apply(pbPhotoCropped);
            //ln.Apply(pbPhotoCropped);

            // Enhance spots of image
            EnhanceBmp(pbPhotoCropped);
            
            // Cutout everything but the specied region (path)
            ClipBmp(pbPhotoCropped, innerPath);
            
            // Dispose of used resources
            pbPhotoCopy.Dispose();

            return pbPhotoCropped;
        }

        public Bitmap GetManualFeature(Bitmap pbPhoto, Point[] pbAnchors)
        {
            // Create a copy of the input image
            Bitmap pbPhotoCopy = GetStandardizedBmp(pbPhoto, pbAnchors);

            // Get a cropped copy of the standardized image
            Bitmap pbPhotoCropped = GetCroppedBmp(pbPhotoCopy);

            // Cutout everything but the specified region (path)
            ClipBmp(pbPhotoCropped, outerPath);

            // Improve brightness/contrast of image
            //histogramCorrection.Apply(pbPhotoCropped);
            //ln.Apply(pbPhotoCropped);

            // Enhance spots of image
            adaptiveThreshold.Apply(pbPhotoCropped, smoothing, radius, threshold);

            // Cutout everything but the specied region (path)
            ClipBmp(pbPhotoCropped, innerPath);

            // Dispose of used resources
            pbPhotoCopy.Dispose();

            return pbPhotoCropped;
        }

        private Bitmap GetStandardizedBmp(Bitmap bmp, Point[] fromPts)
        {
            // Standardized anchor points to transform to
            Point[] toPts = new Point[3];
            toPts[0] = new Point(7, 6);
            toPts[1] = new Point(59, 6);
            toPts[2] = new Point(32, 53);

            Bitmap stdBmp = null;

            // Create a blank bitmap big enough to fit standardized photo
            if (bmp.Width < 480 || bmp.Height < 480)
            {
                stdBmp = new Bitmap(1000, 1000);
            }
            else if (bmp.Width > bmp.Height)
            {
                stdBmp = new Bitmap(bmp.Width*2, bmp.Width*2);
            }
            else
            {
                stdBmp = new Bitmap(bmp.Height*2, bmp.Height*2);
            }

            // Draw bmp onto this new bitmap
            using (Graphics g = Graphics.FromImage(stdBmp))
            {
                g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
            }

            // Apply transformation
            affineTransform.Apply(stdBmp, fromPts, toPts);

            return stdBmp;
        }
        
        private void EnhanceBmp(Bitmap bmp)
        {
            smoothing = DEFAULT_SMOOTHING;
            radius = DEFAULT_RADIUS;
            threshold = 2;

            int blackPixelCount = int.MaxValue;

            // Declare temporary bmp for threshold trials
            Bitmap tempBmp = null;

            int targetBlackPixelCount = CalculateTargetBlackPixelCount(bmp);

            // Increase threshold until black pixels > specified
            while (blackPixelCount > targetBlackPixelCount) // Used to be fixed at 900
            {
                // Get original image
                tempBmp = bmp.Clone() as Bitmap;

                // Apply adaptive threshold
                adaptiveThreshold.Apply(tempBmp, smoothing, radius, threshold);

                // Isolate region containing spots
                ClipBmp(tempBmp, innerPath);

                // Count black spots on image
                blackPixelCount = CountBlackPixels(tempBmp);

                // Dispose temporary bmp
                tempBmp.Dispose();

                // Try next threshold
                threshold++;
            }

            // Go back to immediately preceding threshold
            threshold--;

            // Apply best threshold
            adaptiveThreshold.Apply(bmp, smoothing, radius, threshold);
        }

        private int CalculateTargetBlackPixelCount(Bitmap bmp)
        {
            // Make a copy of bitmap
            Bitmap bmpCopy = bmp.Clone() as Bitmap;

            // Greyscale image
            (new Greyscale()).Apply(bmpCopy);

            // Crop inner portion (based on adaptive threshold radius)
            Bitmap croppedBmp = new Bitmap(bmpCopy.Width - DEFAULT_RADIUS, bmpCopy.Height - DEFAULT_RADIUS);
            Graphics g = Graphics.FromImage(croppedBmp);
            g.DrawImage(bmpCopy, -DEFAULT_RADIUS, -DEFAULT_RADIUS);
            g.Dispose();

            // Obtain histogram
            int[] histogram = GetHistogram(croppedBmp);

            croppedBmp.Dispose();
            bmpCopy.Dispose();
/*
            // Find the 2 most common pixel value
            int maxCount1 = 0;
            int maxCount2 = 0;
            int maxPixel1 = 0;
            int maxPixel2 = 0;
            for (int i = 100; i < 255; i++) // Skip 255 because there are a lot due to irregular cropping above
            {
                if (histogram[i] > maxCount1)
                {
                    maxCount2 = maxCount1;
                    maxPixel2 = maxPixel1;

                    maxCount1 = histogram[i];
                    maxPixel1 = i;
                }
                else if (histogram[i] > maxCount2)
                {
                    maxCount2 = histogram[i];
                    maxPixel2 = i;
                }
            }

            int maxPixel = (int)(((double)maxPixel1 + maxPixel2) / 2.0);

            // Add all histogram values above it (skipping 255)
            int sumAbove = 0;
            for (int a = maxPixel; a < 255; a++)
            {
                sumAbove += histogram[a];
            }

            // Multiply by 2 (area of "whiteness")
            sumAbove = (int)(sumAbove * 2.0);

            // Starting at 254, add down until the sum above is reached
            int pixel = 0;
            int sumDown = 0;
            for (pixel = 254; sumDown < sumAbove; pixel--)
            {
                sumDown += histogram[pixel];
            }
*/

            // Do weighted average, then multiply by 0.9 (emprical number)
            int histoSum = 0;
            for(int h = 0; h < 255; h++)
            {
                histoSum += histogram[h];
            }
            double pixelSum = 0.0;
            for (int i = 0; i < 255; i++)
            {
                pixelSum += (double)i * (double)histogram[i] / histoSum;
            }

            int pixel = (int)(pixelSum * 0.8);

            // Add all histogram values below it
            int sum = 0;
            for (int j = pixel; j >= 0; j--)
            {
                sum += histogram[j];
            }

            // Multiply by empirical factor
            sum = (int)(sum * 0.75);

            return sum;
        }

        private int[] GetHistogram(Bitmap bmp)
        {
            int[] histogram = new int[256];
            for (int h = 0; h < 256; h++)
            {
                histogram[h] = 0;
            }

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    histogram[bmp.GetPixel(i, j).R]++;
                }
            }

            return histogram;
        }

        private Bitmap GetCroppedBmp(Bitmap bmp)
        {
            // Create a small (cropped) bitmap
            Bitmap croppedBmp = new Bitmap(70, 70);

            // Draw the input bitmap on it
            using (Graphics g = Graphics.FromImage(croppedBmp))
            {
                g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
            }

            return croppedBmp;
        }

        private void ClipBmp(Bitmap bmp, Point[] path)
        {
            // Create a graphics path to define clip region
            byte pathType = (byte)PathPointType.Line;
            byte[] pathTypes = { pathType, pathType, pathType, pathType };
            GraphicsPath gPath = new GraphicsPath(path, pathTypes);
            gPath.CloseFigure();

            // Draw image on a clipped region
            Bitmap originalBmp = bmp.Clone() as Bitmap;
            Graphics gBmp = Graphics.FromImage(bmp);
            gBmp.Clear(Color.White);
            gBmp.Clip = new Region(gPath);
            gBmp.DrawImage(originalBmp, 0, 0, bmp.Width, bmp.Height);

            // Dispose of resources
            originalBmp.Dispose();
        }
        
        private int CountBlackPixels(Bitmap bmp)
        {
            // Get the width and height of the image
            int width = bmp.Width;
            int height = bmp.Height;

            // Lock image1 data
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData imageData = bmp.LockBits(rect, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            // Get some image constants
            int bpp = 4;
            int stride = imageData.Stride;

            int count = 0;

            unsafe
            {
                // Get pointers to origin for images
                byte* imagePtrOrigin = (byte*)imageData.Scan0;

                // Start pointers at origin
                byte* imagePtr = imagePtrOrigin;

                int i, j;

                // Use counts and percentage to convert to image
                for (j = 0; j < height; j++)
                {
                    for (i = 0; i < width; i++)
                    {
                        // Point to correct pixel
                        imagePtr = imagePtrOrigin + (i * bpp) + (j * stride);

                        if (imagePtr[0] == 0)
                        {
                            count++;
                        }
                    }
                }
            }

            // Unlock image data
            bmp.UnlockBits(imageData);

            return count;
        }


        private void DefineInnerFeaturePath()
        {
            innerPath = new Point[4];
            innerPath[0] = new Point(7, 6);
            innerPath[1] = new Point(59, 6);
            innerPath[2] = new Point(59, 53);
            innerPath[3] = new Point(7, 53);
        }

        private void DefineOuterFeaturePath()
        {
            outerPath = new Point[4];
            outerPath[0] = new Point(0, 0);
            outerPath[1] = new Point(66, 0);
            outerPath[2] = new Point(66, 60);
            outerPath[3] = new Point(0, 60);
        }

        private static int DEFAULT_SMOOTHING = 1;
        private static int DEFAULT_RADIUS = 4;
        private static int DEFAULT_THRESHOLD = 2;

        private AffineTransform affineTransform = new AffineTransform();
        private AdaptiveThreshold adaptiveThreshold = new AdaptiveThreshold();
        private HistogramCorrection histogramCorrection = new HistogramCorrection();
        private Ln ln = new Ln();

        private Point[] outerPath;
        private Point[] innerPath;

        private int smoothing = DEFAULT_SMOOTHING;
        private int radius = DEFAULT_RADIUS;
        private int threshold = DEFAULT_THRESHOLD;
    }
}
