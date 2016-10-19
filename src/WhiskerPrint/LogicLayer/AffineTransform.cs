using System.Drawing;
using System.Drawing.Drawing2D;

namespace WhiskerPrint.LogicLayer
{
    public class AffineTransform
    {
        public void Apply(Bitmap image, Point[] from, Point[] to)
        {
            Image originalImage = null;
            Graphics g = null;

            try
            {
                // Unit rectangle
                Rectangle unitRect = new Rectangle(0, 0, 1, 1);

                // Matrix transform from unit to "from" polygon
                Matrix A = new Matrix(unitRect, from);

                // Matrix transform from unit to "to" polygon
                Matrix B = new Matrix(unitRect, to);

                // Matrix transform from "from" to "to" polygon
                A.Invert();
                B.Multiply(A);

                // Store an original copy of the image
                originalImage = image.Clone() as Image;

                // Create a graphics to perform affine transformation
                g = Graphics.FromImage(image);

                // Paint entire image white
                Rectangle imageRect = new Rectangle(0, 0, image.Width, image.Height);
                g.FillRectangle(Brushes.White, imageRect);

                // Transform image and draw it
                g.Transform = B;
                g.DrawImage(originalImage, 0, 0, originalImage.Width, originalImage.Height);
            }
            catch
            {
            }
            finally
            {
                // Free resources
                if (originalImage != null)
                {
                    originalImage.Dispose();
                }

                if (g != null)
                {
                    g.Dispose();
                }
            }
        }
    }
}
