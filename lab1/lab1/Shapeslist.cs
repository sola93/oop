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
        public static List<Figure> list = new List<Figure>();
        
        static Shapeslist()
        {
            list.Add(new Circle(new Point(30, 30), 20));
            list.Add(new Ellipse(new Point(30, 30), 50, 30));
            list.Add(new Square(new Point(100, 100), 50));
            list.Add(new Shapes.Rectangle(new Point(100, 100), 20, 80));
            list.Add(new Segment(new Point(30,30), new Point(60,70)));
            list.Add(new Triangle(new Point(30,30), new Point(80,100), new Point(20,70)));
        }
    }
}
