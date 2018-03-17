using System.Drawing;
using lab2.Shapes;

namespace lab2.Visitor
{
    // Used patterns: Visitor and Strategy(IStrategy)   
    interface IVisitor
    {
        void Draw(Graphics g, Figure figure);
    }
}
