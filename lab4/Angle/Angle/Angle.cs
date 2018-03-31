using System.Drawing;
using lab4.Strategy;

namespace Angle
{
    public class Angle : Polyline
    {
        public Angle(IDraw draw, Point point1, Point point2, Point point3) : base(draw)
        {
            AddPoint(point1);
            AddPoint(point2);
            AddPoint(point3);
        }
        public Angle() { }
    }
}
