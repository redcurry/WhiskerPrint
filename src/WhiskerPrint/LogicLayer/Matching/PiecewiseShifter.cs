using System;
using System.Drawing;

namespace WhiskerPrint.LogicLayer.Matching
{
    public class PiecewiseShifter : IMatcherExtra
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
                matcher.Progress += new EventHandler(OnProgress);
            }
        }

        public Size BlockSize
        {
            get
            {
                return blockSize;
            }
            set
            {
                blockSize = value;
            }
        }
        public int Offset
        {
            get
            {
                return offset;
            }
            set
            {
                offset = value;
            }
        }
        public int Step
        {
            get
            {
                return step;
            }
            set
            {
                step = value;
            }
        }

        public PiecewiseShifter(IMatcher m)
        {
            matcher = m;
        }

        public double GetScore(Image image1, Image image2)
        {
            blockSize = new Size(10, 10);
            if (blockSize == Size.Empty)
            {
                throw new Exception("Block size must be specified.");
            }

            return GetDirectedScore(image1, image2);

            /* I don't know yet whether I'll need the following...

            double score1 = GetDirectedScore(image1, image2);
            double score2 = GetDirectedScore(image2, image1);

            return (score1 + score2) / 2.0;

            */
        }

        public int CountSteps()
        {
            return 1;
        }

        private double GetDirectedScore(Image image1, Image image2)
        {
            // Report progress
            OnProgress(this, EventArgs.Empty);

            double scoreSum = 0.0;
            int scoreCount = 0;

            for (int image1BlockJ = 0; image1BlockJ < image1.Height; image1BlockJ += blockSize.Height)
            {
                for (int image1BlockI = 0; image1BlockI < image1.Width; image1BlockI += blockSize.Width)
                {
                    // Create a new bitmap block and draw corresponding piece on it
                    Bitmap image1BlockBmp = new Bitmap(blockSize.Width, blockSize.Height);
                    using(Graphics image1BlockBmpG = Graphics.FromImage(image1BlockBmp))
                    {
                        image1BlockBmpG.DrawImage(image1, -image1BlockI, -image1BlockJ);
                    }

                    double minScore = double.PositiveInfinity;
                    double currentScore = 0.0;

                    for (int j = -offset; j <= offset; j += step)
                    {
                        for (int i = -offset; i <= offset; i += step)
                        {
                            int image2BlockI = image1BlockI + i;
                            int image2BlockJ = image1BlockJ + j;
                            int image2BlockRight = image2BlockI + blockSize.Width;
                            int image2BlockBottom = image2BlockJ + blockSize.Height;

                            // Skip this shifting position if image2 block is out of bounds
                            if (image2BlockI < 0 || image2BlockRight >= image2.Width ||
                                image2BlockJ < 0 || image2BlockBottom >= image2.Height)
                            {
                                continue;
                            }

                            // Create a new bitmap block and draw corresponding piece on it
                            Bitmap image2BlockBmp = new Bitmap(blockSize.Width, blockSize.Height);
                            using (Graphics image2BlockBmpG = Graphics.FromImage(image2BlockBmp))
                            {
                                image2BlockBmpG.DrawImage(image2, -image2BlockI, -image2BlockJ);
                            }

                            // Computer score between blocks
                            currentScore = matcher.GetScore(image1BlockBmp, image2BlockBmp);

                            if (currentScore < minScore)
                            {
                                minScore = currentScore;
                            }

                            image2BlockBmp.Dispose();
                        }
                    }

                    // Add up scores from each block comparison
                    if (minScore < double.PositiveInfinity)
                    {
                        scoreSum += minScore;
                        scoreCount++;
                    }

                    image1BlockBmp.Dispose();
                }
            }

            // Return average of scores
            return (double)scoreSum / scoreCount;
        }

        private void OnProgress(object sender, EventArgs e)
        {
            if (Progress != null)
            {
                Progress(this, EventArgs.Empty);
            }
        }

        private Size blockSize = Size.Empty;
        private int offset = 0;
        private int step = 0;

        private IMatcher matcher = null;
    }
}
