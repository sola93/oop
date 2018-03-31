using System.Drawing;
using lab4.Strategy;

namespace lab4.Shapes
{
    public class Square : Rectangle
    {
        public Square(IDraw draw, Point topleft, int side) : base(draw, topleft, side, side) { }

        public Square() { }
    }
}
