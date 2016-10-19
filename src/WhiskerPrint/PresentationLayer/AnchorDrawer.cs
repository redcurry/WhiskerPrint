using System.Drawing;

namespace WhiskerPrint.PresentationLayer
{
    public class AnchorDrawer
    {
        private static int anchorSize = 10;

        public void DrawAnchor(Graphics g, Point p, Color c)
        {
            if (p != Point.Empty)
            {
                // Create pen based on color
                Pen pen = new Pen(c);

                // Draw outer circle of anchor
                g.DrawEllipse(pen, p.X - anchorSize / 2, p.Y - anchorSize / 2, anchorSize, anchorSize);

                // Draw inner dot of anchor
                g.DrawRectangle(pen, p.X, p.Y, 0.5f, 0.5f);

                // Dispose of pen
                pen.Dispose();
            }
        }

        public void DrawAnchor(Graphics g, Point p, double xScale, double yScale, Color c)
        {
            DrawAnchor(g, new Point((int)(p.X * xScale), (int)(p.Y * yScale)), c);
        }
    }
}
