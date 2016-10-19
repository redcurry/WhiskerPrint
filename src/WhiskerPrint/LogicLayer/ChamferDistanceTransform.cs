using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace WhiskerPrint.LogicLayer
{
    public class ChamferDistanceTransform
    {
        public enum DistanceMethods
        {
            Median,
            Mean
        }

        // Optimization: Radius of comparison on image 2
        private static int OptRadius = 1;
        private static int OptRadius2 = 3;

        // Smallest double possible
        private static double epsilon = double.Epsilon;

        // Optimization: Bounds of image1 and image2
        private static int image1Top;
        private static int image1Bottom;
        private static int image1Left;
        private static int image1Right;
        private static int image2Top;
        private static int image2Bottom;
        private static int image2Left;
        private static int image2Right;

        public DistanceMethods DistanceMethod
        {
            get
            {
                return _distanceMethods;
            }
            set
            {
                _distanceMethods = value;
            }
        }

        public double getDistance(Image image1, Image image2)
        {
            Bitmap image1Bmp = image1 as Bitmap;
            Bitmap image2Bmp = image2 as Bitmap;

            // Lock image1 data
            Rectangle rect1 = new Rectangle(0, 0, image1Bmp.Width, image1Bmp.Height);
            BitmapData image1Data = image1Bmp.LockBits(rect1, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            // Lock image2 data
            Rectangle rect2 = new Rectangle(0, 0, image2Bmp.Width, image2Bmp.Height);
            BitmapData image2Data = image2Bmp.LockBits(rect2, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            // Get some image constants
            int bpp = 4;
            int stride1 = image1Data.Stride;
            int stride2 = image2Data.Stride;
            int width1 = image1Bmp.Width;
            int height1 = image1Bmp.Height;
            int width2 = image2Bmp.Width;
            int height2 = image2Bmp.Height;

            // Reset optimization image bounds
            image1Top = height1 - 1;
            image1Bottom = 0;
            image1Left = width1 - 1;
            image1Right = 0;
            image2Top = height2 - 1;
            image2Bottom = 0;
            image2Left = width2 - 1;
            image2Right = 0;

            double distance = 0.0;
            int count = 0;

            // Used for median option
            double[] distances = null;
            int blackCount = 0;

            int i, j;

            unsafe
            {
                // Get pointers to origin for images
                byte* image1PtrOrigin = (byte*)image1Data.Scan0;
                byte* image2PtrOrigin = (byte*)image2Data.Scan0;

                // Declare image pointers
                byte* image1Ptr = null;
                byte* image2Ptr = null;

                if (_distanceMethods == DistanceMethods.Median)
                {
                    // Used for median: count # of black pixels
                    for (j = 0; j < height1; j++)
                    {
                        for (i = 0; i < width1; i++)
                        {
                            image1Ptr = image1PtrOrigin + (i * bpp) + (j * stride1);
                            if (image1Ptr[0] == 0)
                            {
                                blackCount++;
                            }
                        }
                    }
                    distances = new double[blackCount];
                    blackCount = 0;
                }

                // Optimization: Get images' top, bottom, left, and right bounds
                for (j = 0; j < height1; j++)
                {
                    for (i = 0; i < width1; i++)
                    {
                        // Point to correct pixel
                        image1Ptr = image1PtrOrigin + (i * bpp) + (j * stride1);

                        if (image1Ptr[0] == 0)
                        {
                            if (i < image1Left)
                            {
                                image1Left = i;
                            }

                            if (i > image1Right)
                            {
                                image1Right = i;
                            }

                            if (j < image1Top)
                            {
                                image1Top = j;
                            }

                            if (j > image1Bottom)
                            {
                                image1Bottom = j;
                            }
                        }
                    }
                }

                // Optimization: Get images' top, bottom, left, and right bounds
                for (j = 0; j < height2; j++)
                {
                    for (i = 0; i < width2; i++)
                    {
                        // Point to correct pixel
                        image2Ptr = image2PtrOrigin + (i * bpp) + (j * stride2);

                        if (image2Ptr[0] == 0)
                        {
                            if (i < image2Left)
                            {
                                image2Left = i;
                            }

                            if (i > image2Right)
                            {
                                image2Right = i;
                            }

                            if (j < image2Top)
                            {
                                image2Top = j;
                            }

                            if (j > image2Bottom)
                            {
                                image2Bottom = j;
                            }
                        }
                    }
                }

                for (j = image1Top; j <= image1Bottom; j++)
                {
                    for (i = image1Left; i <= image1Right; i++)
                    {
                        // Point to correct pixel
                        image1Ptr = image1PtrOrigin + (i * bpp) + (j * stride1);

                        if (_distanceMethods == DistanceMethods.Mean)
                        {
                            if (image1Ptr[0] == 0)
                            {
                                distance += getNearestDistance(image2PtrOrigin,
                                    width2, height2, i, j, bpp, stride2);

                                count++;
                            }
                        }
                        else
                        {
                            // Median option
                            if (image1Ptr[0] == 0)
                            {
                                distances[blackCount++] = getNearestDistance(image2PtrOrigin,
                                    width2, height2, i, j, bpp, stride2);
                            }
                        }
                    }
                }
            }

            // Unlock image data
            image1Bmp.UnlockBits(image1Data);
            image2Bmp.UnlockBits(image2Data);

            // Median option
            if (_distanceMethods == DistanceMethods.Median)
            {
                Array.Sort(distances);
                if (blackCount == 0)
                {
                    return Double.PositiveInfinity;
                }
                else
                {
                    return distances[blackCount / 2];
                }
            }
            else
            {
                return distance / count;
            }
        }

        private unsafe double getNearestDistance(byte* image2PtrOrigin, int width, int height, int i1, int j1, int bpp, int stride2)
        {
            double minDistance = double.MaxValue;

            byte* image2Ptr = null;

            // Find the minimum distance within a small neighborhood
            minDistance = getNeighborhoodMinDistance(i1, j1, OptRadius,
                image2PtrOrigin, width, height, bpp, stride2);
            
            // If found, return it; otherwise, go on
            if (minDistance >= 0.0)
            {
                // Optimization: Make optRadius a bit bigger than min distance
                //OptRadius = (int)minDistance + 10;
                return minDistance;
            }

            // Find the minimum distance within a bigger neighborhood
            minDistance = getNeighborhoodMinDistance(i1, j1, OptRadius2,
                image2PtrOrigin, width, height, bpp, stride2);

            // If found, return it; otherwise, go on
            if (minDistance >= 0.0)
            {
                return minDistance;
            }

            // Give up optimization, and search everything
            minDistance = getCompleteMinDistance(i1, j1,
                image2PtrOrigin, width, height, bpp, stride2);

            return minDistance;
        }

        private unsafe double getCompleteMinDistance(int i1, int j1,
            byte* image2PtrOrigin, int width, int height, int bpp, int stride2)
        {
            // Start by assuming the minumum distance is very large
            double minDistance = double.MaxValue;

            // Initialize pointer to current pixel
            byte* image2Ptr = null;

            // Declare current distance once
            double distance;

            // Declare indexes once
            int i2, j2;

            for (j2 = image2Top; j2 <= image2Bottom; j2++)
            {
                for (i2 = image2Left; i2 < image2Right; i2++)
                {
                    // Determine index of current pixel
                    image2Ptr = image2PtrOrigin + (i2 * bpp) + (j2 * stride2);

                    // Examine only black pixels
                    if (image2Ptr[0] == 0)
                    {
                        // Get the distance between pixels
                        distance = getPixelDistance(i1, j1, i2, j2);

                        // Update new minimum distance
                        if (distance < minDistance)
                        {
                            // Update minimum distance
                            minDistance = distance;

                            // Minimum distance found if it is 0
                            if (minDistance < epsilon)
                            {
                                return 0.0;
                            }
                        }
                    }
                }
            }

            return minDistance;
        }

        private unsafe double getNeighborhoodMinDistance(int i1, int j1,
            int radius, byte* image2PtrOrigin, int width, int height, int bpp, int stride)
        {
            // Calculate where neighborhood starts and ends
            int i2Start = i1 - radius;
            int i2End = i1 + radius;
            int j2Start = j1 - radius;
            int j2End = j1 + radius;

            // Adjust for out of bounds
            i2Start = i2Start < 0 ? 0 : i2Start;
            i2End = i2End < width ? i2End : width - 1;
            j2Start = j2Start < 0 ? 0 : j2Start;
            j2End = j2End < height ? j2End : height - 1;

            // Start by assuming the minumum distance is very large
            double minDistance = double.MaxValue;

            // Keep track of whether a minimum was found
            bool minFound = false;

            // Initialize pointer to current pixel
            byte* image2Ptr = null;

            // Declare current distance once
            double distance;

            // Declare indexes once
            int i2, j2;

            for (j2 = j2Start; j2 <= j2End; j2++)
            {
                for (i2 = i2Start; i2 <= i2End; i2++)
                {
                    // Determine index of current pixel (no bounds check)
                    image2Ptr = image2PtrOrigin + (i2 * bpp) + (j2 * stride);

                    // Examine only black pixels
                    if (image2Ptr[0] == 0)
                    {
                        // Get the distance between pixels
                        distance = getPixelDistance(i1, j1, i2, j2);
                        
                        // Update new minimum distance
                        if (distance < minDistance)
                        {
                            // Minimum found (optimization worked)
                            minFound = true;

                            // Update minimum distance
                            minDistance = distance;

                            // Minimum distance found if it is 0
                            if (minDistance < epsilon)
                            {
                                return 0.0;
                            }
                        }
                    }
                }
            }

            // Return minimum distance if it was found;
            // otherwise, return a negative number
            if (minFound)
            {
                return minDistance;
            }
            else
            {
                return -1.0;
            }
        }

        private unsafe double getNeighborhoodMinDistance_old(int i1, int j1,
            int radius, byte* image2PtrOrigin, int width, int height, int bpp, int stride)
        {
            // Calculate where neighborhood starts and ends
            int i2Start = i1 - radius;
            int i2End = i1 + radius;
            int j2Start = j1 - radius;
            int j2End = j1 + radius;

            // Check if any index is out of bounds
            bool neighborhoodOutOfBounds = false;
            if ((i2Start < 0) || (i2End >= width) ||
                (j2Start < 0) || (j2End >= height))
            {
                neighborhoodOutOfBounds = true;
            }

            // Start by assuming the minumum distance is very large
            double minDistance = double.MaxValue;

            // Keep track of whether a minimum was found
            bool minFound = false;

            // Initialize pointer to current pixel
            byte* image2Ptr = null;

            // Declare current distance once
            double distance;

            // Declare indexes once
            int i2, j2;

            for (j2 = j2Start; j2 <= j2End; j2++)
            {
                for (i2 = i2Start; i2 <= i2End; i2++)
                {
                    // If any neighborhood edge was out of bounds, then check
                    // every pixel within neighborhood if it is out of bounds
                    if (neighborhoodOutOfBounds)
                    {
                        // Determine index of current pixel (bounds check)
                        image2Ptr = getImagePtr(image2PtrOrigin, i2, j2,
                            width, height, bpp, stride);

                        // Go to next pixel if it is out of bounds
                        if (image2Ptr == null)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        // Determine index of current pixel (no bounds check)
                        image2Ptr = image2PtrOrigin + (i2 * bpp) + (j2 * stride);
                    }

                    // Examine only black pixels
                    if (image2Ptr[0] == 0)
                    {
                        // Get the distance between pixels
                        distance = getPixelDistance(i1, j1, i2, j2);

                        // Update new minimum distance
                        if (distance < minDistance)
                        {
                            // Minimum found (optimization worked)
                            minFound = true;

                            // Update minimum distance
                            minDistance = distance;

                            // Minimum distance found if it is 0
                            if (minDistance < epsilon)
                            {
                                return 0.0;
                            }
                        }
                    }
                }
            }

            // Return minimum distance if it was found;
            // otherwise, return a negative number
            if (minFound)
            {
                return minDistance;
            }
            else
            {
                return -1.0;
            }
        }

        private double getPixelDistance(int i1, int j1, int i2, int j2)
        {
            return Math.Sqrt((i2 - i1) * (i2 - i1) + (j2 - j1) * (j2 - j1));
        }

        private unsafe byte* getImagePtr(byte* originPtr, int i, int j,
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

        private DistanceMethods _distanceMethods = DistanceMethods.Median;
    }
}
