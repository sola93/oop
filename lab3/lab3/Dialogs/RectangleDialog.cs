using System;
using System.Drawing;
using System.Windows.Forms;
using lab3.Shapes;
using Rectangle = lab3.Shapes.Rectangle;

namespace lab3.Dialogs
{
    public partial class RectangleDialog : FigureDialog
    {
        public RectangleDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                EditShape((Rectangle)Figure);
            }
            else
                AddShape();
        }

        public override void AddShape()
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Rectangle rectangle = new Rectangle(point1, int.Parse(Width.Text), int.Parse(Height.Text));
            ShapesList.AddShape(rectangle);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void EditShape(Figure figure)
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(point1.X + int.Parse(Width.Text), point1.Y);
            Point point3 = new Point(point1.X + int.Parse(Width.Text), point1.Y - int.Parse(Height.Text));
            Point point4 = new Point(point1.X, point1.Y - int.Parse(Height.Text));
            figure.Edit(point1, point2, point3, point4);          
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void Clean()
        {
            Point1X.Clear();
            Point1Y.Clear();
            Width.Clear();
            Height.Clear();
        }

        private void Activate(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                Rectangle rectangle = (Rectangle) Figure;
                Point1X.Text = rectangle.Points[0].X.ToString();
                Point1Y.Text = rectangle.Points[1].Y.ToString();
                Width.Text = Convert.ToString(rectangle.Points[1].X - rectangle.Points[0].X);
                Height.Text = Convert.ToString(rectangle.Points[0].Y - rectangle.Points[2].Y);
            }
            else
            {
                Clean();
            }
        }
    }
}
