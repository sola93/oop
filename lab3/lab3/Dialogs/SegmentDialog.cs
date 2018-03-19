using System;
using System.Drawing;
using System.Windows.Forms;
using lab3.Shapes;

namespace lab3.Dialogs
{
    public partial class SegmentDialog : FigureDialog
    {
        public SegmentDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                EditShape((Segment)Figure);
            }
            else
                AddShape();
        }

        public override void AddShape()
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(int.Parse(Point2X.Text), int.Parse(Point2Y.Text));
            Segment segment = new Segment(point1, point2);
            ShapesList.AddShape(segment);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void EditShape(Figure figure)
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(int.Parse(Point2X.Text), int.Parse(Point2Y.Text));
            figure.Edit(point1, point2);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void Clean()
        {
            Point1X.Clear();
            Point1Y.Clear();
            Point2X.Clear();
            Point2Y.Clear();
        }

        private void Activate(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                Segment segment = (Segment) Figure;
                Point1X.Text = segment.Points[0].X.ToString();
                Point1Y.Text = segment.Points[0].Y.ToString();
                Point2X.Text = segment.Points[1].X.ToString();
                Point2Y.Text = segment.Points[1].Y.ToString();
            }
            else
            {
                Clean();
            }
        }
    }
}
