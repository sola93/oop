using lab1.Shapes;
using System.Collections.Generic;
using System.Drawing;
using lab1.Visitor;

namespace lab1
{
    class Shapeslist
    {
        public static List<Figure> List;

        static Shapeslist()
        {
            List = new List<Figure>();
        }
        public static void AddShape(Figure figure)
        {
            List.Add(figure);
        }

        public static void RemoveShape(Figure figure)
        {
            List.Remove(figure);
        }

        public static void Accept(IVisitor visitor, Graphics g)
        {
            foreach (var t in List)
                t.Accept(visitor, g);
        }
    }
}
