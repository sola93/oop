using System.Collections.Generic;
using System.Drawing;
using lab4.Strategy;

namespace lab4.Shapes
{
    public class Polygon : Figure
    {
        public List<Point> Points;
        public Polygon(IDraw draw) : base(draw)
        {
            Points = new List<Point>();
        }

        public Polygon() { }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public override void DrawFigure(Graphics g)
        {
            Draw.Draw(g, this);
        }
    }
}
