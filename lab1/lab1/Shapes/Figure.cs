using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
