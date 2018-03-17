using System.Drawing;
using lab1.Shapes;

namespace lab1.Visitor
{
    interface IVisitor
    {
        void Visit(Graphics g, Ellipse ellipse);
        void Visit(Graphics g, Polygon polygon);
    }
}
