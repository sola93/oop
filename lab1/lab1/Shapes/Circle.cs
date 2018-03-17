using System.Drawing;

namespace lab1.Shapes
{
    class Circle : Ellipse
    {
        public Circle(Point center, int radius) : base(new Point(center.X - radius, center.Y + radius), radius * 2, radius * 2)
        {
        }
    }
}
