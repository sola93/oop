using System.Collections.Generic;
using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    class Polygon : Figure
    {
        public List<Point> Points;
        public Polygon(IVisitor visitor) : base(visitor)
        {
            Points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        //Call Strategy
        public override void Accept(Graphics g, IVisitor visitor)
        {
            visitor.Draw(g, this);
        }
    }
}
