using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Shapes
{
    class Polygon : Figure
    {
        public List<Point> points;
        public Polygon()
        {
            points = new List<Point>();
        }
        public Polygon (List<Point> points)
        {
            this.points = points;
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
        }
        public override void Accept(IVisitor visitor, Graphics g)
        {
            visitor.Visit(g, this);
        }
    }
}
