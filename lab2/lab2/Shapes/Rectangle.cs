using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    class Rectangle : Polygon
    {
        public Rectangle(IVisitor visitor, Point topleft, int width, int height) : base(visitor)
        {
            AddPoint(topleft);
            AddPoint(new Point(topleft.X + width, topleft.Y));
            AddPoint(new Point(topleft.X + width, topleft.Y - height));
            AddPoint(new Point(topleft.X, topleft.Y - height));
        }
    }
}
