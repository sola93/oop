using System;
using System.Drawing;
using lab4.Shapes;

namespace lab4.Strategy
{
    public class PolygonDraw : IDraw
    {
        public void Draw(Graphics g, Figure figure)
        {
            Polygon polygon = (Polygon) figure;
            g.DrawPolygon(polygon.Pen, polygon.Points.ToArray());
        }
    }
}
