using System;
using System.Drawing;
using System.Windows.Forms;
using lab3.Shapes;

namespace lab3.Dialogs
{
    public partial class CircleDialog : FigureDialog
    {
        public CircleDialog()
        {
            InitializeComponent();
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                EditShape((Circle)Figure);
            }
            else
                AddShape();
        }

        public override void AddShape()
        {
            int radius = int.Parse(RadiusX.Text);
            Point topLeft = new Point(int.Parse(X.Text) - radius, int.Parse(Y.Text) - radius);
            Circle circle = new Circle(topLeft, radius);
            ShapesList.AddShape(circle);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void EditShape(Figure figure)
        {
            int radius = int.Parse(RadiusX.Text);
            Point topLeft = new Point(int.Parse(X.Text) - radius, int.Parse(Y.Text) - radius);
            figure.Edit(topLeft, radius*2, radius*2);
            MessageBox.Show(@"Success");
            Clean();
        }

        public override void Clean()
        {
            X.Clear();
            Y.Clear();
            RadiusX.Clear();
        }

        private void Activate(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                Circle circle = (Circle)Figure;
                X.Text = Convert.ToString(circle.TopLeft.X + circle.Width/2);
                Y.Text = Convert.ToString(circle.TopLeft.Y + circle.Width/2);
                RadiusX.Text = (circle.Width / 2).ToString();
            }
            else
            {
                Clean();
            }
        }
    }
}
