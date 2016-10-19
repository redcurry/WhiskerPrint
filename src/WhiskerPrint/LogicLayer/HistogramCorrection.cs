using System.Drawing;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer
{
    public class HistogramCorrection
    {
        public static int[] CumulHistogram = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 3, 3, 4, 4, 4, 6, 6, 9, 9, 9, 12, 12, 12, 15, 15, 23, 23, 23, 30, 30, 40, 65, 65, 65, 65, 65, 73, 89, 89, 89, 89, 107, 107, 107, 132, 132, 132, 132, 147, 169, 169, 169, 169, 198, 223, 223, 241, 241, 241, 281, 281, 331, 331, 331, 358, 358, 417, 417, 455, 455, 455, 517, 517, 560, 560, 560, 627, 627, 721, 721, 721, 795, 795, 842, 842, 944, 944, 944, 1021, 1021, 1079, 1079, 1079, 1183, 1183, 1238, 1238, 1341, 1341, 1341, 1456, 1456, 1516, 1516, 1516, 1677, 1677, 1732, 1868, 1868, 1868, 1932, 2070, 2070, 2070, 2070, 2204, 2282, 2282, 2359, 2359, 2359, 2359, 2435, 2518, 2518, 2518, 2518, 2743, 2743, 2743, 2743, 2811, 2876, 2876, 3045, 3045, 3045, 3128, 3128, 3286, 3286, 3365, 3365, 3461, 3461, 3548, 3548, 3548, 3749, 3749, 3826, 3826, 3826, 3924, 4121, 4121, 4220, 4220, 4220, 4301, 4301, 4407, 4407, 4407, 4506, 4620, 4620, 4854, 4854, 4854, 4983, 4983, 5105, 5105, 5105, 5375, 5671, 5671, 5671, 5809, 5809, 6103, 6378, 6378, 6378, 6656, 6870, 6870, 6870, 6870, 7066, 7066, 7279, 7514, 7514, 7514, 7659, 7771, 7771, 7771, 7771, 7893, 7965, 8030, 8030, 8030, 8080, 8080, 8098, 8098, 8098, 8136, 8155, 8155, 8166, 8166, 8166, 8169, 8169, 8175, 8175, 8179, 8179, 8179 };

        public void Apply(Bitmap image)
        {
            // Get the width and height of the image
            int width = image.Width;
            int height = image.Height;

            // Lock image1 data
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            // Get some image constants
            int bpp = 4;
            int stride = imageData.Stride;

            // Create array to store histogram
            int[] cumulHistogram = new int[256];

            unsafe
            {
                // Get pointers to origin for images
                byte* imagePtrOrigin = (byte*)imageData.Scan0;

                // Start pointers at origin
                byte* imagePtr = imagePtrOrigin;

                int i, j;

                // Populate histogram
                for (j = 0; j < height; j++)
                {
                    for (i = 0; i < width; i++)
                    {
                        // Point to correct pixel
                        imagePtr = imagePtrOrigin + (i * bpp) + (j * stride);

                        // Update histogram
                        cumulHistogram[imagePtr[0]]++;
                    }
                }

                // Do cumulative histogram
                for (i = 1; i < 256; i++)
                {
                    cumulHistogram[i] += cumulHistogram[i - 1];
                }

                byte pixel;
                for (j = 0; j < height; j++)
                {
                    for (i = 0; i < width; i++)
                    {
                        // Point to correct pixel
                        imagePtr = imagePtrOrigin + (i * bpp) + (j * stride);

                        pixel = imagePtr[0];

                        // Skip white pixels
                        if (pixel == 255)
                        {
                            continue;
                        }

                        int cumul = cumulHistogram[pixel];

                        int k = 0;
                        while (CumulHistogram[k] < cumul)
                        {
                            k++;
                        }

                        imagePtr[0] = imagePtr[1] = imagePtr[2] = (byte)k;
                    }
                }
            }

            // Unlock image data
            image.UnlockBits(imageData);
        }
    }
}
