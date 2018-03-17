using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    class Ellipse : Figure
    {
        public Point TopLeft;
        public int Width;
        public int Height;
        public new IVisitor Visitor;
        public Ellipse(IVisitor visitor, Point topleft, int width, int height) : base(visitor)
        {
            TopLeft = topleft;
            Width = width;
            Height = height;
            Visitor = visitor;

        }

        //Call Strategy
        public override void Accept(Graphics g, IVisitor visitor)
        {
            visitor.Draw(g, this);
        }
    }
}
