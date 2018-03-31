using System.Drawing;
using lab4.Strategy;

namespace lab4.Shapes
{
    public class Circle : Ellipse
    {
        public Circle(IDraw draw, Point topleft, int radius) : base(draw, topleft, radius * 2, radius * 2)
        {
        }
        public Circle() { }
    }
}
