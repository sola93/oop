using System.Drawing;

namespace lab1.Shapes
{
    class Segment : Polygon
    {
        public Segment(Point point, Point point2)
        {
            AddPoint(point);
            AddPoint(point2);
        }
    }
}
