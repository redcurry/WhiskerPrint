using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer
{
    public class Ln
    {
        public void Apply(Bitmap image)
        {
            // Lock image1 data
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            // Get some image constants
            int bpp = 4;
            int stride = imageData.Stride;
            int width = image.Width;
            int height = image.Height;

            byte min = 255;
            byte max = 0;

            unsafe
            {
                // Get pointers to origin for images
                byte* imagePtrOrigin = (byte*)imageData.Scan0;

                // Start pointers at origin
                byte* imagePtr = imagePtrOrigin;

                int i, j;

                // Find min and max pixels
                for (j = 0; j < height; j++)
                {
                    for (i = 0; i < width; i++)
                    {
                        // Point to correct pixel
                        imagePtr = imagePtrOrigin + (i * bpp) + (j * stride);

                        if (imagePtr[0] < min)
                        {
                            min = imagePtr[0];
                        }

                        if (imagePtr[0] > max)
                        {
                            max = imagePtr[0];
                        }
                    }
                }

                double c = 255.0 / Math.Log((1 + max) / (1 + min));

                // Find min and max pixels
                for (j = 0; j < height; j++)
                {
                    for (i = 0; i < width; i++)
                    {
                        // Point to correct pixel
                        imagePtr = imagePtrOrigin + (i * bpp) + (j * stride);

                        imagePtr[0] = imagePtr[1] = imagePtr[2] =
                            (byte)(c * Math.Log((1 + imagePtr[0]) / (1 + min)));
                    }
                }
            }

            // Unlock image data
            image.UnlockBits(imageData);
        }
    }
}
