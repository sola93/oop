using System.Drawing;

namespace lab3.Shapes
{
    public class Square : Rectangle
    {
        public Square(Point topleft, int side) : base(topleft, side, side) { }
        public Square() { }
    }
}
