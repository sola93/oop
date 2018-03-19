using System;
using System.Drawing;
using System.Windows.Forms;
using lab3.Shapes;

namespace lab3.Dialogs
{
    public partial class TriangleDialog : FigureDialog
    {
        public TriangleDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                EditShape((Triangle)Figure);
            }
            else
                AddShape();
        }

        public override void AddShape()
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(int.Parse(Point2X.Text), int.Parse(Point2Y.Text));
            Point point3 = new Point(int.Parse(Point3X.Text), int.Parse(Point3Y.Text));
            Triangle triangle = new Triangle(point1, point2, point3);
            ShapesList.AddShape(triangle);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void EditShape(Figure figure)
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(int.Parse(Point2X.Text), int.Parse(Point2Y.Text));
            Point point3 = new Point(int.Parse(Point3X.Text), int.Parse(Point3Y.Text));
            figure.Edit(point1, point2, point3);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void Clean()
        {
            Point1X.Clear();
            Point2X.Clear();
            Point3X.Clear();
            Point1Y.Clear();
            Point2Y.Clear();
            Point3Y.Clear();
        }

        private void Activate(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                Triangle triangle = (Triangle) Figure;
                Point1X.Text = triangle.Points[0].X.ToString();
                Point1Y.Text = triangle.Points[0].Y.ToString();
                Point2X.Text = triangle.Points[1].X.ToString();
                Point2Y.Text = triangle.Points[1].Y.ToString();
                Point3X.Text = triangle.Points[2].X.ToString();
                Point3Y.Text = triangle.Points[2].Y.ToString();
            }
        }
    }
}
