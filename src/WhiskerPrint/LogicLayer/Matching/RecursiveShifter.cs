using System;
using System.Collections.Generic;
using System.Drawing;

namespace WhiskerPrint.LogicLayer.Matching
{
    public class RecursiveShifter : IMatcherExtra
    {
        public event EventHandler Progress;

        public IMatcher Matcher
        {
            get
            {
                return matcher;
            }
            set
            {
                matcher = value;
            }
        }

        public RecursiveShifter(IMatcher m)
        {
            Matcher = m;
        }

        public double GetScore(Image image1, Image image2)
        {
            OnProgress(this, EventArgs.Empty);

            // Store bottom image (for visualizer)
            bottomImage = image2;

            // Clear number of pieces
            totalPieces = 0;

            topCoords.Clear();
            topImages.Clear();

            // TODO: May want to do bidirectional
            double score = GetRecursiveScore(image1, image2, new Point(0,0), 12.0);

            if (totalPieces > 0)
            {
                return score / totalPieces;
            }
            else
            {
                return score;
            }
        }

        public int CountSteps()
        {
            return 1;
        }

        // Assumption: image1 can be nicely split into specified #
        private double GetRecursiveScore(Image image1, Image image2, Point image1Coord, double maxMove)
        {
            // Calculate the location that results in the minimum score
            Point minScoreCoord = GetMinScoreCoord(image1, image2, image1Coord, maxMove);

            // Base case: image size is too small to continue splitting
            if (image1.Width <= 24) // TODO: Let user specify minimum image width
            {
                // Store this top image and its coordinate (for visualizer)
                //topImages.Add(new Bitmap(image1));          // TODO: Must dispose at some point
                //topCoords.Add(minScoreCoord);

                // If got a score, this is a piece; otherwise,
                // ignore piece (could be a blank area)
                if (lastMinScore > 0.0)
                {
                    totalPieces++;
                }

                return lastMinScore; // Calculated in last call to GetMinScoreCoord
            }

            // Split the top image into the specified number (in one dimension)
            Image[] imagePieces = GetSplitImage(image1, 2); // TODO: Let user specify split #
            
            // Get the coordinates of the image pieces from the last split,
            // and offset by the coord that resulted in the minimum score
            Point[] imagePieceCoords = lastSplitCoords;
            for (int i = 0; i < imagePieceCoords.Length; i++)
            {
                imagePieceCoords[i].Offset(minScoreCoord);
            }

            // Add up the scores calculated recursively for each image piece
            double score = 0;
            for(int i = 0; i < imagePieces.Length; i++)
            {
                Image imagePiece = imagePieces[i];
                Point imagePieceCoord = imagePieceCoords[i];

                score += GetRecursiveScore(imagePiece, image2, imagePieceCoord, maxMove);
            }

            // Destroy image pieces
            foreach (Image image in imagePieces)
            {
                image.Dispose();
            }

            return score;
        }

        private double GetDistance(Point p, Point q)
        {
            int dx = p.X - q.X;
            int dy = p.Y - q.Y;

            return Math.Sqrt((dx * dx) + (dy * dy));
        }

        // Image width and height should be divisible by n
        private Image[] GetSplitImage(Image image, int n)
        {
            // There will be n * n image pieces since n is in one dimension
            Image[] imagePieces = new Image[n * n];

            // Create a point array to hold coordinates of image pieces
            lastSplitCoords = new Point[n * n];

            int iStep = image.Width / n;
            int jStep = image.Height / n;

            int m = 0;
            for (int i = 0; i < image.Width; i += iStep)
            {
                for (int j = 0; j < image.Height; j += jStep)
                {
                    lastSplitCoords[m] = new Point(i, j);
                    
                    // Create the image piece
                    imagePieces[m] = new Bitmap(iStep, jStep);
                    using (Graphics g = Graphics.FromImage(imagePieces[m]))
                    {
                        g.DrawImage(image, -lastSplitCoords[m].X, -lastSplitCoords[m].Y);
                    }

                    m++;
                }
            }

            return imagePieces;
        }

        // Split image horizontally only (may work better on polar bears)
        private Image[] GetSplitImageHorizontal(Image image, int n)
        {
            Image[] imagePieces = new Image[n];

            lastSplitCoords = new Point[n];

            int iStep = image.Width / n;

            int m = 0;
            for (int i = 0; i < image.Width; i += iStep)
            {
                lastSplitCoords[m] = new Point(i, 0);

                imagePieces[m] = new Bitmap(iStep, image.Height);
                using (Graphics g = Graphics.FromImage(imagePieces[m]))
                {
                    g.DrawImage(image, -lastSplitCoords[m].X, 0);
                }

                m++;
            }

            return imagePieces;
        }

        private Point GetMinScoreCoord(Image image1, Image image2, Point image1Coord, double maxMove)
        {
            double minScore = double.PositiveInfinity;
            double score = 0.0;

            Point minNeighborCoord = Point.Empty;
            Point neighborCoord = Point.Empty;

            // Find the neighbor that gives the minimum score
            for (int q = -1; q <= 1; q++)
            {
                for (int p = -1; p <= 1; p++)
                {
                    neighborCoord = image1Coord;
                    neighborCoord.Offset(p, q);

                    // Bound check
                    if (neighborCoord.X <= -image1.Width || neighborCoord.Y <= -image1.Height
                        || neighborCoord.X >= image2.Width || neighborCoord.Y >= image2.Height)
                    {
                        continue;
                    }

                    // Make sure it hasn't moved past maxMove
                    if (GetDistance(neighborCoord, image1Coord) > maxMove)
                    {
                        continue;
                    }

                    score = GetScore(image1, image2, neighborCoord);

                    if (score < minScore)
                    {
                        minScore = score;
                        minNeighborCoord = neighborCoord;
                    }
                }
            }

            // If neighbor is itself, return the minimum score;
            // otherwise, recurse using the best neighber
            if (minNeighborCoord == image1Coord)
            {
                lastMinScore = minScore;
                return minNeighborCoord;
            }
            else
            {
                double move = GetDistance(minNeighborCoord, image1Coord);
                return GetMinScoreCoord(image1, image2, minNeighborCoord, maxMove - move);
            }
        }

        private double GetScore(Image image1, Image image2, Point image1Coord)
        {
            Image image1Cropped = null;
            Image image2Cropped = null;

            image1Cropped = CropTopImage(image1, image2, image1Coord.X, image1Coord.Y);
            image2Cropped = CropBottomImage(image1, image2, image1Coord.X, image1Coord.Y);

            return matcher.GetScore(image1Cropped, image2Cropped);
        }

        // Top image shifts (image1)
        private Image CropTopImage(Image image1, Image image2, int i, int j)
        {
            int widthCropped, heightCropped;
            int xCropped, yCropped;

            if (i < 0)
            {
                widthCropped = image1.Width + i;
                xCropped = i;
            }
            else if (i + image1.Width > image2.Width)
            {
                widthCropped = image2.Width - i;
                xCropped = 0;
            }
            else
            {
                widthCropped = image1.Width;
                xCropped = 0;
            }

            if (j < 0)
            {
                heightCropped = image1.Height + j;
                yCropped = j;
            }
            else if (j + image1.Height > image2.Height)
            {
                heightCropped = image2.Height - j;
                yCropped = 0;
            }
            else
            {
                heightCropped = image1.Height;
                yCropped = 0;
            }

            Image image1Cropped = new Bitmap(widthCropped, heightCropped);
            using (Graphics image1CroppedGraphics = Graphics.FromImage(image1Cropped))
            {
                image1CroppedGraphics.DrawImage(image1, xCropped, yCropped);
            }

            return image1Cropped;
        }

        // Bottom image does not shift (image2)
        private Image CropBottomImage(Image image1, Image image2, int i, int j)
        {

            int widthCropped, heightCropped;
            int xCropped, yCropped;

            if (i < 0)
            {
                widthCropped = image1.Width + i;
                xCropped = 0;
            }
            else if (i + image1.Width > image2.Width)
            {
                widthCropped = image2.Width - i;
                xCropped = -i;
            }
            else
            {
                widthCropped = image1.Width;
                xCropped = -i;
            }

            if (j < 0)
            {
                heightCropped = image1.Height + j;
                yCropped = 0;
            }
            else if (j + image1.Height > image2.Height)
            {
                heightCropped = image2.Height - j;
                yCropped = -j;
            }
            else
            {
                heightCropped = image1.Height;
                yCropped = -j;
            }

            Image image2Cropped = new Bitmap(widthCropped, heightCropped);
            using (Graphics image2CroppedGraphics = Graphics.FromImage(image2Cropped))
            {
                image2CroppedGraphics.DrawImage(image2, xCropped, yCropped);
            }

            return image2Cropped;
        }

        private void OnProgress(object sender, EventArgs e)
        {
            if (Progress != null)
            {
                Progress(sender, e);
            }
        }

        private IMatcher matcher = null;
        private double lastMinScore = 0.0;
        private Point[] lastSplitCoords = null;

        // Keep track of the # of pieces (for dividing total score)
        private int totalPieces = 0;

        // For visualizer
        private Image bottomImage = null;
        private List<Image> topImages = new List<Image>();
        private List<Point> topCoords = new List<Point>();
    }
}
