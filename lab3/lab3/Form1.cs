using System;
using System.Collections.Generic;
using System.Windows.Forms;
using lab3.Dialogs;
using lab3.Shapes;

namespace lab3
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, FigureDialog> _forms = new Dictionary<string, FigureDialog>()
        {
            {"Circle", new CircleDialog() },
            {"Ellipse", new EllipseDialog() },
            {"Rectangle", new RectangleDialog() },
            {"Segment", new SegmentDialog() },
            {"Square", new SquareDialog() },
            {"Triangle", new TriangleDialog() }
        };
        private const string File = "Shapes.xml";

        public Form1()
        {
            InitializeComponent();
            ListUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Serializer.Serialize(ShapesList.List, File);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _forms[listBox2.SelectedItem.ToString()].ShowDialog();
            ListUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var t in Serializer.Deserialize<List<Figure>>(File))
            {
                ShapesList.AddShape(t);
            }
            ListUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _forms[listBox1.SelectedItem.ToString()].Figure = ShapesList.List[listBox1.SelectedIndex];
            _forms[listBox1.SelectedItem.ToString()].ShowDialog();
            ListUpdate();
        }

        private void ListUpdate()
        {
            listBox1.Items.Clear();
            foreach (var t in ShapesList.List)
            {
                listBox1.Items.Add(t);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShapesList.RemoveShape(ShapesList.List[listBox1.SelectedIndex]);
            ListUpdate();
        }
    }
}
