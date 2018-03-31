using System.Drawing;
using lab4.Strategy;

namespace lab4.Shapes
{
    public class Segment : Polygon
    {
        public Segment(IDraw draw, Point point1, Point point2) : base(draw)
        {
            AddPoint(point1);
            AddPoint(point2);
        }

        public Segment() { }
    }
}
