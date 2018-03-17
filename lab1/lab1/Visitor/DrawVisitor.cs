using System.Drawing;
using lab1.Shapes;

namespace lab1.Visitor
{
    class DrawVisitor : IVisitor
    {
        public void Visit(Graphics g, Ellipse ellipse)
        {
            g.DrawEllipse(ellipse.Pen, ellipse.Topleft.X, ellipse.Topleft.Y, ellipse.Width, ellipse.Height);
        }
        public void Visit(Graphics g, Polygon polygon)
        {
            g.DrawPolygon(polygon.Pen, polygon.points.ToArray());
        }
    }
}
