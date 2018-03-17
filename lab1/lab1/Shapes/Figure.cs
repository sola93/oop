using System.Drawing;
using lab1.Visitor;

namespace lab1.Shapes
{
    abstract class Figure
    {
        public Pen Pen { get; set; }
        public Figure()
        {
            Pen = new Pen(Brushes.Red)
            {
                Width = 2
            };
        }

        public abstract void Accept(IVisitor visitor, Graphics g);

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
