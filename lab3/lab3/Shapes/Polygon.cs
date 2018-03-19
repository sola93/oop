using System.Collections.Generic;
using System.Drawing;

namespace lab3.Shapes
{
    public class Polygon : Figure
    {
        public List<Point> Points;
        public Polygon() 
        {
            Points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public override void Edit(params object[] parameters)
        {
            Points.Clear();
            foreach (var t in parameters)
            {
                Points.Add((Point)t);
            }
        }
    }
}
