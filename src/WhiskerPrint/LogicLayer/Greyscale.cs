using System.Drawing;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer
{
    public class Greyscale
    {
        public void Apply(Bitmap image)
        {
            // Lock image data
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            // Get width and height of image data
            // (can be different from bitmap due to "stride")
            int imageDataWidth = image.Width;
            int imageDataHeight = image.Height;

            // Get some image constants
            int bytesPerPixel = 4;
            int stride = imageData.Stride;

            unsafe
            {
                // Get pointer to image bytes
                byte* imageBytes = (byte*)imageData.Scan0;

                for (int j = 0; j < imageDataHeight; j++)
                {
                    for (int i = 0; i < imageDataWidth; i++)
                    {
                        // Get RGB values (order is BGR)
                        byte r = imageBytes[2];
                        byte g = imageBytes[1];
                        byte b = imageBytes[0];

                        // Convert RGB to grayscale
                        byte grey = (byte)(0.30 * r + 0.59 * g + 0.11 * b);
                        imageBytes[0] = imageBytes[1] = imageBytes[2] = grey;

                        // Go to next pixel
                        imageBytes += 4;
                    }

                    // Go to beginning of next line
                    imageBytes += stride - imageDataWidth * bytesPerPixel;
                }
            }

            // Unlock image data
            image.UnlockBits(imageData);
        }
    }
}
