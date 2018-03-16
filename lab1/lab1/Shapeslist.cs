using lab1.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Shapeslist
    {
        public static List<Figure> list;

        static Shapeslist()
        {
            list = new List<Figure>();
        }
        public static void AddShape(Figure figure)
        {
            list.Add(figure);
        }

        public static void RemoveShape(Figure figure)
        {
            list.Remove(figure);
        }

        public static void Accept(IVisitor visitor, Graphics g)
        {
            foreach (var t in list)
                t.Accept(visitor, g);
        }
    }
}
