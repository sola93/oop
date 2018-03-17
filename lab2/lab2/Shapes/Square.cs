using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    class Square : Rectangle
    {
        public Square(IVisitor visitor, Point topleft, int side) : base(visitor, topleft, side, side) { }
    }
}
