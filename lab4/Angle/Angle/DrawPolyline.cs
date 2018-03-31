using System.Drawing;
using lab4.Shapes;
using lab4.Strategy;

namespace Angle
{
    class DrawPolyline : IDraw
    {
        public void Draw(Graphics g, Figure figure)
        {
            Angle angle = (Angle) figure;
            g.DrawLines(figure.Pen, angle.Points.ToArray());
        }
    }
}
