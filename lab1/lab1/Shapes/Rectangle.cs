using System.Drawing;

namespace lab1.Shapes
{
    class Rectangle : Polygon
    {
        public Rectangle(Point topleft, int width, int height)
        {
            AddPoint(topleft);
            AddPoint(new Point(topleft.X + width, topleft.Y));
            AddPoint(new Point(topleft.X + width, topleft.Y - height));
            AddPoint(new Point(topleft.X, topleft.Y - height));
        }
    }
}
