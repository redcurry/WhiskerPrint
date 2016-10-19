using System.Drawing;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer
{
    public class Mean
    {
        public void Apply(Bitmap image, int radius)
        {
            // Copy the image
            Bitmap imageCopy = image.Clone() as Bitmap;

            // Lock image data
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            BitmapData imageCopyData = imageCopy.LockBits(rect, ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            // Get width and height of image
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            // Get some image constants
            int bpp = 4;
            int stride = imageData.Stride;
            int size = stride * imageHeight;

            unsafe
            {
                // Get pointers to origin for images
                byte* imagePtrOrigin = (byte*)imageData.Scan0;
                byte* imageCopyPtrOrigin = (byte*)imageCopyData.Scan0;

                // Start pointers at origin
                byte* imagePtr = imagePtrOrigin;
                byte* imageCopyPtr = imageCopyPtrOrigin;

                // Calculate area of neighborhood
                int neighCount = (2 * radius + 1) * (2 * radius + 1);

                for (int j = radius; j < imageHeight - radius; j++)
                {
                    for (int i = radius; i < imageWidth - radius; i++)
                    {
                        // Point to correct pixel
                        imagePtr = imagePtrOrigin + (i * bpp) + (j * stride);
                        imageCopyPtr = imageCopyPtrOrigin + (i * bpp) + (j * stride);

                        // Store pixel value sum
                        int sum = 0;

                        // Go through each neighborhood pixel
                        for (int q = -radius; q <= radius; q++)
                        {
                            for (int p = -radius; p <= radius; p++)
                            {
                                sum += (imageCopyPtr + (p * bpp) + (q * stride))[0];
                            }
                        }

                        imagePtr[0] = imagePtr[1] = imagePtr[2] = (byte)(sum / neighCount);
                    }
                }
            }

            // Unlock image data
            image.UnlockBits(imageData);
            imageCopy.UnlockBits(imageCopyData);
        }
    }
}
