﻿using System.Collections.Generic;
using System.Drawing;
using lab2.Shapes;

namespace lab2
{
    //List of Shapes
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
        //call method accept for all shapes in list
        public static void Accept(Graphics g)
        {
            foreach (var t in List)
            {
                t.Accept(g, t.Visitor);
            }
        }
    }
}
