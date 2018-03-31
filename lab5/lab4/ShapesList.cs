using System.Collections.Generic;
using System.Drawing;
using lab4.Shapes;

namespace lab4
{
    public class ShapesList
    {
        public static List<Figure> List;

        static ShapesList()
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

        public static void Draw(Graphics g)
        {
            foreach (var t in List)
            {
                t.DrawFigure(g);
            }
        }
    }
}
