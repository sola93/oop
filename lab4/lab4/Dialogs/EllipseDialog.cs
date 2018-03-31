using System;
using System.Drawing;
using System.Windows.Forms;
using lab4.Shapes;
using lab4.Strategy;

namespace lab4.Dialogs
{
    public partial class EllipseDialog : FigureDialog
    {
        public EllipseDialog()
        {
            InitializeComponent();
        }

        //Add Figure to List
        private void button1_Click(object sender, EventArgs e)
        {
            AddShape();
        }

        public override void Clean()
        {
            X.Clear();
            Y.Clear();
            RadiusY.Clear();
            RadiusX.Clear();
        }

        public override void AddShape()
        {
            int radiusX = int.Parse(RadiusX.Text);
            int radiusY = int.Parse(RadiusY.Text);
            Point topLeft = new Point(int.Parse(X.Text) - radiusX, int.Parse(Y.Text) - radiusY);
            Ellipse ellipse = new Ellipse(new EllipseDraw(), topLeft, radiusX * 2, radiusY * 2);
            ShapesList.AddShape(ellipse);
            Clean();
            MessageBox.Show(@"Success");
        }
    }
}
