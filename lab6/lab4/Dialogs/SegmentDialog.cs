using System;
using System.Drawing;
using System.Windows.Forms;
using lab4.Shapes;
using lab4.Strategy;

namespace lab4.Dialogs
{
    public partial class SegmentDialog : FigureDialog
    {
        public SegmentDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddShape();
        }

        public override void Clean()
        {
            Point1X.Clear();
            Point1Y.Clear();
            Point2X.Clear();
            Point2Y.Clear();
        }

        public override void AddShape()
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(int.Parse(Point2X.Text), int.Parse(Point2Y.Text));
            Segment segment = new Segment(new PolygonDraw(), point1, point2);
            ShapesList.AddShape(segment);
            Clean();
            MessageBox.Show(@"Success");
        }
    }
}
