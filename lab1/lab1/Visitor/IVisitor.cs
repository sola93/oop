using lab1.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    interface IVisitor
    {
        void Visit(Graphics g, Ellipse ellipse);
        void Visit(Graphics g, Polygon polygon);
    }
}
