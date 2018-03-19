using System.Drawing;

namespace lab3.Shapes
{
    public class Triangle : Polygon
    {
        public Triangle(Point point1, Point point2, Point point3)
        {
            AddPoint(point1);
            AddPoint(point2);
            AddPoint(point3);
        }

        public Triangle() { }
    }
}
