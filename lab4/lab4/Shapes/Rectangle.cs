using System.Drawing;
using lab4.Strategy;

namespace lab4.Shapes
{
    public class Rectangle : Polygon
    {
        public Rectangle(IDraw draw, Point topleft, int width, int height) : base(draw)
        {
            AddPoint(topleft);
            AddPoint(new Point(topleft.X + width, topleft.Y));
            AddPoint(new Point(topleft.X + width, topleft.Y - height));
            AddPoint(new Point(topleft.X, topleft.Y - height));
        }

        public Rectangle() { }
    }
}
