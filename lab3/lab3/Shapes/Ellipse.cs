using System;
using System.Drawing;
using System.Xml.Serialization;

namespace lab3.Shapes
{
    public class Ellipse : Figure
    {
        public Point TopLeft;
        public int Width;
        public int Height;
        public Ellipse(Point topleft, int width, int height)
        {
            TopLeft = topleft;
            Width = width;
            Height = height;
        }
        public Ellipse() { }

        public override void Edit(params object[] parameters)
        {
            TopLeft = (Point)parameters[0];
            Width = (int) parameters[1];
            Height = (int) parameters[2];
        }
    }
}
