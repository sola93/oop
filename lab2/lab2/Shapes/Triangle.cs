using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    class Triangle : Polygon
    {
        public Triangle(IVisitor visitor, Point point1, Point point2, Point point3) : base(visitor)
        {
            AddPoint(point1);
            AddPoint(point2);
            AddPoint(point3);
        }
    }
}
