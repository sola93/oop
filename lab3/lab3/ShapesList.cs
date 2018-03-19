using System.Collections.Generic;
using lab3.Shapes;

namespace lab3
{
    class ShapesList
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
    }
}
