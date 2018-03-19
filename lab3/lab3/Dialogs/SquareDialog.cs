using System;
using System.Drawing;
using System.Windows.Forms;
using lab3.Shapes;

namespace lab3.Dialogs
{
    public partial class SquareDialog : FigureDialog
    {
        public SquareDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                EditShape((Square)Figure);
            }
            else
                AddShape();
        }

        public override void AddShape()
        {
            Point topleft = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Square square = new Square(topleft, int.Parse(Width.Text));
            ShapesList.AddShape(square);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void EditShape(Figure figure)
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(point1.X + int.Parse(Width.Text), point1.Y);
            Point point3 = new Point(point1.X + int.Parse(Width.Text), point1.Y - int.Parse(Width.Text));
            Point point4 = new Point(point1.X, point1.Y - int.Parse(Width.Text));
            figure.Edit(point1, point2, point3, point4);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void Clean()
        {
            Point1X.Clear();
            Point1Y.Clear();
            Width.Clear();
        }

        private void Activate(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                Square square = (Square) Figure;
                Point1X.Text = square.Points[0].X.ToString();
                Point1Y.Text = square.Points[1].Y.ToString();
                Width.Text = Convert.ToString(square.Points[1].X - square.Points[0].X);
            }
            else
            {
                Clean();
            }
        }
    }
}
