using System;
using System.Drawing;
using System.Windows.Forms;
using lab2.Shapes;
using lab2.Visitor;

namespace lab2.Dialogs
{
    public partial class SquareDialog : FigureDialog
    {
        public SquareDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddShape();
        }

        public override void Clean()
        {
            Width.Clear();
            Point1X.Clear();
            Point1Y.Clear();
        }

        public override void AddShape()
        {
            Point topleft = new Point(int.Parse(Point1X.Text),
                int.Parse(Point1Y.Text));
            Square square = new Square(new PolygonVisitor(), topleft, int.Parse(Width.Text));
            ShapesList.AddShape(square);
            MessageBox.Show(@"Success");
            Clean();
        }
    }
}
