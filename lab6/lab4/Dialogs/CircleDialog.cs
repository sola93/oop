using System.Drawing;
using System.Windows.Forms;
using lab4.Shapes;
using lab4.Strategy;

namespace lab4.Dialogs
{
    public partial class CircleDialog : FigureDialog
    {
        public CircleDialog()
        {
            InitializeComponent();
        }

        public override void Clean()
        {
            RadiusX.Clear();
            X.Clear();
            Y.Clear();
        }

        public override void AddShape()
        {
            int radius = int.Parse(RadiusX.Text);
            Point topLeft = new Point(int.Parse(X.Text) - radius, int.Parse(Y.Text) - radius);
            Circle circle = new Circle(new EllipseDraw(), topLeft, radius);
            ShapesList.AddShape(circle);
            Clean();
            MessageBox.Show(@"Success");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AddShape();
        }
    }
}
