using System;
using System.Drawing;
using System.Xml.Serialization;

namespace lab3.Shapes
{
    public class Circle : Ellipse
    {
        public Circle(Point topleft, int radius) : base(topleft, radius * 2, radius * 2)
        {
        }
        public Circle() { }
    }
}
