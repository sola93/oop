using System.Drawing;
using System.Xml.Serialization;
using lab4.Strategy;

namespace lab4.Shapes
{
    public abstract class Figure
    {
        [XmlIgnore]
        public Pen Pen;
        [XmlIgnore]
        public IDraw Draw;
        protected Figure(IDraw draw)
        {
            Draw = draw;
            Pen = new Pen(Brushes.Red)
            {
                Width = 2
            };
        }

        protected Figure() { }

        public abstract void DrawFigure(Graphics g);
    }
}
