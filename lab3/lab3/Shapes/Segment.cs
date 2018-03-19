using System.Drawing;

namespace lab3.Shapes
{
    public class Segment : Polygon
    {
        public Segment(Point point1, Point point2)
        {
            AddPoint(point1);
            AddPoint(point2);
        }

        public Segment() { }
    }
}
