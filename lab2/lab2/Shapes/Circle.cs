using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    class Circle : Ellipse
    {
        public Circle(IVisitor visitor, Point topleft, int radius) : base(visitor, topleft, radius * 2, radius * 2)
        {
        }
    }
}
