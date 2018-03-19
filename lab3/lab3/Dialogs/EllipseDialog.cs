using System;
using System.Drawing;
using System.Windows.Forms;
using lab3.Shapes;

namespace lab3.Dialogs
{
    public partial class EllipseDialog : FigureDialog
    {
        public EllipseDialog()
        {
            InitializeComponent();
        }

        public override void AddShape()
        {
            int radiusX = int.Parse(RadiusX.Text);
            int radiusY = int.Parse(RadiusY.Text);
            Point topLeft = new Point(int.Parse(X.Text) - radiusX, int.Parse(Y.Text) - radiusY);
            Ellipse ellipse = new Ellipse(topLeft, radiusX * 2, radiusY * 2);
            ShapesList.AddShape(ellipse);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void EditShape(Figure figure)
        {
            int radiusX = int.Parse(RadiusX.Text);
            int radiusY = int.Parse(RadiusY.Text);
            Point topLeft = new Point(int.Parse(X.Text) - radiusX, int.Parse(Y.Text) - radiusY);
            figure.Edit(topLeft, radiusX*2, radiusY*2);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void Clean()
        {
            X.Clear();
            Y.Clear();
            RadiusX.Clear();
            RadiusY.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                EditShape((Ellipse)Figure);
            }
            else
                AddShape();
        }

        private void Activate(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                Ellipse ellipse = (Ellipse) Figure;
                X.Text = Convert.ToString(ellipse.TopLeft.X + ellipse.Width/2);
                Y.Text = Convert.ToString(ellipse.TopLeft.Y + ellipse.Height/2);
                RadiusX.Text = (ellipse.Width / 2).ToString();
                RadiusY.Text = (ellipse.Height / 2).ToString();
            }
            else
            {
                Clean();
            }
        }
    }
}
