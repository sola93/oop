using System.Drawing;
using System.Windows.Forms;
using lab2.Shapes;
using lab2.Visitor;

namespace lab2.Dialogs
{
    public partial class TriangleDialog : FigureDialog
    {
        public TriangleDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AddShape();
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

        public override void AddShape()
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(int.Parse(Point2X.Text), int.Parse(Point2Y.Text));
            Point point3 = new Point(int.Parse(Point3X.Text), int.Parse(Point3Y.Text));
            Triangle triangle = new Triangle(new PolygonVisitor(), point1, point2, point3);
            ShapesList.AddShape(triangle);
            Clean();
            MessageBox.Show(@"Success");
        }
    }
}
