using System.Drawing;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer
{
    public class AdaptiveThreshold
    {
        public void Apply(Bitmap image, int meanRadius, int radius, int threshold)
        {
            // Convert image to greyscale
            greyscale.Apply(image);

            // Perform mean on image
            mean.Apply(image, meanRadius);

            // Copy the image
            Bitmap greyImage = image.Clone() as Bitmap;

            // Lock image data
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            BitmapData greyImageData = greyImage.LockBits(rect, ImageLockMode.ReadOnly,
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
                byte* greyImagePtrOrigin = (byte*)greyImageData.Scan0;

                // Start pointers at origin
                byte* imagePtr = imagePtrOrigin;
                byte* greyImagePtr = greyImagePtrOrigin;

                // Calculate area of neighborhood
                int neighCount = (2 * radius + 1) * (2 * radius + 1);

                for (int j = radius; j < imageHeight - radius; j++)
                {
                    for (int i = radius; i < imageWidth - radius; i++)
                    {
                        // Point to correct pixel
                        imagePtr = imagePtrOrigin + (i * bpp) + (j * stride);
                        greyImagePtr = greyImagePtrOrigin + (i * bpp) + (j * stride);

                        // Store pixel value sum
                        int sum = 0;

                        // Go through each neighborhood pixel
                        for (int q = -radius; q <= radius; q++)
                        {
                            for (int p = -radius; p <= radius; p++)
                            {
                                sum += (greyImagePtr + (p * bpp) + (q * stride))[0];
                            }
                        }

                        byte average = (byte)(sum / neighCount);
                        //threshold = (byte)(0.0345 * average + 2.6897);

                        if (greyImagePtr[0] <= average - threshold)
                        {
                            imagePtr[0] = imagePtr[1] = imagePtr[2] = 0;
                        }
                        else
                        {
                            imagePtr[0] = imagePtr[1] = imagePtr[2] = 255;
                        }
                    }
                }
            }

            // Unlock image data
            image.UnlockBits(imageData);
            greyImage.UnlockBits(greyImageData);
        }

        private Greyscale greyscale = new Greyscale();
        private Mean mean = new Mean();
    }
}
