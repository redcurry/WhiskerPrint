using System;
using System.Drawing;

namespace WhiskerPrint.LogicLayer.Matching
{
    public class Shifter : IMatcherExtra
    {
        public event EventHandler Progress;

        public Shifter(IMatcher matcher)
        {
            Matcher = matcher;
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
                _matcher.Progress += new EventHandler(OnProgress);
            }
        }

        public int Offset
        {
            get
            {
                return _offset;
            }
            set
            {
                _offset = value;
            }
        }

        public int Step
        {
            get
            {
                return _step;
            }
            set
            {
                _step = value;
            }
        }

        public double GetScore(Image image1, Image image2)
        {
            // Report progress
            OnProgress(this, EventArgs.Empty);

            // Optimize: Get width and height of images (same for both images)
            int width = image1.Width;
            int height = image1.Height;

            double minScore = double.PositiveInfinity;
            double currentScore = 0.0;

            int minI = 0;
            int minJ = 0;

            int i = 0;
            int j = 0;

            // DEBUG: OPEN FILE TO OUTPUT GRID
            //using (StreamWriter writer = new StreamWriter(@"C:\Documents and Settings\Administrator\Desktop\shifter_EAEQ_Basin.txt"))
            //{
                for (j = -_offset; j <= _offset; j += _step)
                {
                    for (i = -_offset; i <= _offset; i += _step)
                    {
                        int widthCropped = 0;
                        int heightCropped = 0;

                        int image1CroppedX = 0;
                        int image1CroppedY = 0;
                        int image2CroppedX = 0;
                        int image2CroppedY = 0;

                        if (i < 0)
                        {
                            widthCropped = width + i;

                            image1CroppedX = 0;
                            image2CroppedX = i;
                        }
                        else
                        {
                            widthCropped = width - i;

                            image1CroppedX = -i;
                            image2CroppedX = 0;
                        }

                        if (j < 0)
                        {
                            heightCropped = height + j;

                            image1CroppedY = 0;
                            image2CroppedY = j;
                        }
                        else
                        {
                            heightCropped = height - j;

                            image1CroppedY = -j;
                            image2CroppedY = 0;
                        }

                        Bitmap image1Cropped = new Bitmap(widthCropped, heightCropped);
                        using (Graphics image1CroppedGraphics = Graphics.FromImage(image1Cropped))
                        {
                            image1CroppedGraphics.DrawImage(image1, image1CroppedX, image1CroppedY);
                        }

                        Bitmap image2Cropped = new Bitmap(widthCropped, heightCropped);
                        using (Graphics image2CroppedGraphics = Graphics.FromImage(image2Cropped))
                        {
                            image2CroppedGraphics.DrawImage(image2, image2CroppedX, image2CroppedY);
                        }

                        // Get score of cropped images, not the full (avoids calculating distances of edges)
                        currentScore = _matcher.GetScore(image1Cropped, image2Cropped);

                        // DEBUG: OUTPUT GRID WITH ALL SCORES CALCULATED
                        //writer.Write(currentScore.ToString() + "\t");

                        image1Cropped.Dispose();
                        image2Cropped.Dispose();

                        // Keep track of the lowest score
                        if (currentScore < minScore)
                        {
                            minScore = currentScore;
                            minI = i; minJ = j;
                        }
                    }

                    // DEBUG: OUTPUT NEXT LINE
                    //writer.WriteLine();
                }
            //}

            //System.Windows.Forms.MessageBox.Show("Min i, j = " + minI + ", " + minJ);

            return minScore;
        }

        public int CountSteps()
        {
            int steps = 1;    // Own progress

            for (int j = -_offset; j <= _offset; j += _step)
            {
                for (int i = -_offset; i <= _offset; i += _step)
                {
                    steps += _matcher.CountSteps();
                }
            }
            
            return steps;
        }

        private void OnProgress(object sender, EventArgs e)
        {
            if (Progress != null)
            {
                Progress(sender, e);
            }
        }

        private IMatcher _matcher = null;

        private int _offset = 10;
        private int _step = 1;
    }
}
