using System.Collections.Generic;
using System.Drawing;
using lab4.Shapes;
using lab4.Strategy;

namespace Angle
{
    public class Polyline : Figure
    {
        public List<Point> Points;
        public Polyline(IDraw draw) : base(draw)
        {
            Points = new List<Point>();
        }
        public Polyline() { }

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
