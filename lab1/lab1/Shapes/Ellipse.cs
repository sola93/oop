using System.Drawing;
using lab1.Visitor;

namespace lab1.Shapes
{
    class Ellipse : Figure
    {
        public Point Topleft;
        public int Width;
        public int Height;

        public Ellipse(Point topleft, int width, int height)
        {
            Topleft = topleft;
            Width = width;
            Height = height;
        }
        public override void Accept(IVisitor visitor, Graphics g)
        {
            visitor.Visit(g, this);
        }
    }
}
