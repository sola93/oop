using System.Drawing;

namespace Rhomb
{
    class RhombDialog
    {
        public Rhomb AddShape(Point point1, Point point2)
        {
            return new Rhomb(point1, point2);
        }
    }
}
