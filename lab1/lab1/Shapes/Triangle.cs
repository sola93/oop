using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Shapes
{
    class Triangle : Polygon
    {
        public Triangle(Point point, Point point2, Point point3)
        {
            AddPoint(point);
            AddPoint(point2);
            AddPoint(point3);
        }
    }
}
