using System.Drawing;
using System.Windows.Forms;
using lab4.Strategy;
using Rectangle = lab4.Shapes.Rectangle;

namespace lab4.Dialogs
{
    public partial class RectangleDialog : FigureDialog
    {
        public RectangleDialog()
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
            Point1Y.Clear();
            Width.Clear();
            Height.Clear();
        }

        public override void AddShape()
        {
            Point point1 = new Point(int.Parse(Point1X.Text), int.Parse(Point1Y.Text));
            Rectangle rectangle = new Rectangle(new PolygonDraw(), point1, int.Parse(Width.Text), int.Parse(Height.Text));
            ShapesList.AddShape(rectangle);
            MessageBox.Show(@"Success");
            Clean();
        }
    }
}
