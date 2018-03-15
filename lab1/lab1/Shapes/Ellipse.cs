using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Shapes
{
    class Ellipse : Figure
    {
        public Point topleft;
        public int width;
        public int height;

        public Ellipse(Point topleft, int width, int height)
        {
            this.topleft = topleft;
            this.width = width;
            this.height = height;
        }
        public override void Accept(IVisitor visitor, Graphics g)
        {
            visitor.Visit(g, this);
        }
    }
}
