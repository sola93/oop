using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using lab4.Dialogs;
using lab4.Strategy;

namespace lab4
{
    public partial class AdapterDialog : FigureDialog
    {
        private readonly Type _rhombDialog;
        private readonly object _rhombDialogObject;

        public AdapterDialog(Type rhombDialog)
        {
            _rhombDialog = rhombDialog;
            _rhombDialogObject = Activator.CreateInstance(_rhombDialog);
            InitializeComponent();
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
            MethodInfo method = _rhombDialog.GetMethod("AddShape");
            if (method != null)
            {
                var rhomb = method.Invoke(_rhombDialogObject, new object[] {point1, point2});
                Adapter adapter = new Adapter(new PolygonDraw(), rhomb);
                ShapesList.AddShape(adapter);
            }
            MessageBox.Show(@"Success");
            Clean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddShape();
        }
    }
}
