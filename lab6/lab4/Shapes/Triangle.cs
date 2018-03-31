using System.Drawing;
using lab4.Strategy;

namespace lab4.Shapes
{
    public class Triangle : Polygon
    {
        public Triangle(IDraw draw, Point point1, Point point2, Point point3) : base(draw)
        {
            AddPoint(point1);
            AddPoint(point2);
            AddPoint(point3);
        }

        public Triangle() { }
    }
}
