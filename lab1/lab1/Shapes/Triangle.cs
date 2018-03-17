using System.Drawing;

namespace lab1.Shapes
{
    class Triangle : Polygon
    {
        public Triangle(Point point, Point point2, Point point3)
        {
            AddPoint(point);
            AddPoint(point2);
            AddPoint(point3);
        }
    }
}
