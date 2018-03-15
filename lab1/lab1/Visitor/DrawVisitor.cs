using lab1.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class DrawVisitor : IVisitor
    {
        public void Visit(Graphics g, Ellipse ellipse)
        {
            g.DrawEllipse(ellipse.Pen, ellipse.topleft.X, ellipse.topleft.Y, ellipse.width, ellipse.height);
        }
        public void Visit(Graphics g, Polygon polygon)
        {
            g.DrawPolygon(polygon.Pen, polygon.points.ToArray());
        }
    }
}
