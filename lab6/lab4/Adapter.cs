using System;
using System.Drawing;
using System.Reflection;
using lab4.Shapes;
using lab4.Strategy;

namespace lab4
{
    public class Adapter : Polygon
    {
        public Adapter(IDraw draw, object rhomb) : base(draw)
        {
            Type rhombType = rhomb.GetType();
            FieldInfo[] field = rhombType.GetFields();
            Point point1 = (Point) field[0].GetValue(rhomb);
            Point point2 = (Point) field[1].GetValue(rhomb);
            Point point3 = new Point(point2.X + point2.X-point1.X, point1.Y);
            Point point4 = new Point(point2.X,  point1.Y + point1.Y - point2.Y);
            AddPoint(point1);
            AddPoint(point2);
            AddPoint(point3);
            AddPoint(point4);
        }

        public Adapter() { }
    }
}
