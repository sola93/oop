using System.Drawing;
using lab4.Shapes;

namespace lab4.Strategy
{
    public class EllipseDraw : IDraw
    {
        public void Draw(Graphics g, Figure figure)
        {
            Ellipse ellipse = (Ellipse)figure;
            g.DrawEllipse(ellipse.Pen, ellipse.TopLeft.X, ellipse.TopLeft.Y, ellipse.Width, ellipse.Height);
        }
    }
}
