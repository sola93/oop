using System.Drawing;
using lab2.Shapes;

namespace lab2.Visitor
{
    // Used patterns: Visitor and Strategy(PolygonStrategy)
    class PolygonVisitor : IVisitor
    {
        public void Draw(Graphics g, Figure figure)
        {
            Polygon polygon = (Polygon)figure;
            g.DrawPolygon(polygon.Pen, polygon.Points.ToArray());
        }
    }
}
