using System.Drawing;
using lab4.Strategy;

namespace lab4.Shapes
{
    public class Ellipse : Figure
    {
        public Point TopLeft;
        public int Width;
        public int Height;
        public Ellipse(IDraw draw, Point topleft, int width, int height) : base(draw)
        {
            TopLeft = topleft;
            Width = width;
            Height = height;

        }

        public Ellipse() { }

        public override void DrawFigure(Graphics g)
        {
            Draw.Draw(g, this);
        }
    }
}
