using System.Drawing;
using lab2.Shapes;

namespace lab2.Visitor
{
    // Used patterns: Visitor and Strategy(EllipseStrategy)
    class EllipseVisitor : IVisitor
    {
        public void Draw(Graphics g, Figure figure)
        {
            Ellipse ellipse = (Ellipse) figure;
            g.DrawEllipse(ellipse.Pen, ellipse.TopLeft.X, ellipse.TopLeft.Y, ellipse.Width, ellipse.Height);
        }
    }
}
