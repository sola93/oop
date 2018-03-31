using System.Drawing;
using lab4.Shapes;

namespace lab4.Strategy
{
    public interface IDraw
    {
        void Draw(Graphics g, Figure figure);
    }
}
