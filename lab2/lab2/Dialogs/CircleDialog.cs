using System.Drawing;
using System.Windows.Forms;
using lab2.Shapes;
using lab2.Visitor;

namespace lab2.Dialogs
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
            Circle circle = new Circle(new EllipseVisitor(), topLeft, radius);
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
