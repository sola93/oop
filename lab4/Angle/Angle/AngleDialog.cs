using System;
using System.Drawing;
using System.Windows.Forms;
using lab4;
using lab4.Dialogs;

namespace Angle
{
    public partial class AngleDialog :  FigureDialog
    {
        public AngleDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddShape();
        }

        public override void AddShape()
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Point point2 = new Point(int.Parse(Point2X.Text), int.Parse(Point2Y.Text));
            Point point3 = new Point(int.Parse(Point3X.Text), int.Parse(Point3Y.Text));
            Angle angle = new Angle(new DrawPolyline(), point1, point2, point3);
            ShapesList.AddShape(angle);
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
    }
}
