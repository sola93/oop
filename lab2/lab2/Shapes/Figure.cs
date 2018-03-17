using System.Drawing;
using lab2.Visitor;

namespace lab2.Shapes
{
    abstract class Figure
    {
        public Pen Pen;
        //Startegy pattern object(IStrategy)
        public IVisitor Visitor;
        protected Figure(IVisitor visitor)
        {
            Visitor = visitor;
            Pen = new Pen(Brushes.Red)
            {
                Width = 2
            };
        }

        //Visitor pattern method Accept
        public abstract void Accept(Graphics g, IVisitor visitor);
    }
}
