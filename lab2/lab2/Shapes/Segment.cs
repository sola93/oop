using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    class Segment : Polygon
    {
        public Segment(IVisitor visitor, Point point1, Point point2) : base(visitor)
        {
            AddPoint(point1);
            AddPoint(point2);
        }
    }
}
