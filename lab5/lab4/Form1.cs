using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using lab4.Dialogs;
using lab4.Shapes;
using lab4.Strategy;

namespace lab4
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, FigureDialog> Dialogs = new Dictionary<string, FigureDialog>()
        {
            {"Circle", new CircleDialog()},
            {"Ellipse", new EllipseDialog()},
            {"Rectangle", new RectangleDialog()},
            {"Segment", new SegmentDialog()},
            {"Square", new SquareDialog()},
            {"Triangle", new TriangleDialog()}
        };

        public static Dictionary<string, IDraw> Draws = new Dictionary<string, IDraw>
        {
            {"Circle", new EllipseDraw()},
            {"Ellipse", new EllipseDraw()},
            {"Rectangle", new PolygonDraw()},
            {"Square", new PolygonDraw()},
            {"Segment", new PolygonDraw()},
            {"Triangle", new PolygonDraw()}

        };

        private bool _startPaint;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dialogs[listBox1.SelectedItem.ToString()].ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _startPaint = true;
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Serializer.Serialize(ShapesList.List, "serialize.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var t in Serializer.Deserialize<List<Figure>>("serialize.xml"))
            {
                t.Pen = new Pen(Brushes.Red)
                {
                    Width = 2
                };
                t.Draw = Draws[t.GetType().Name];
                ShapesList.AddShape(t);
            }
        }

        private new void Paint(object sender, PaintEventArgs e)
        {
            if (_startPaint)
            {
                ShapesList.Draw(e.Graphics);
                _startPaint = false;
                Refresh();
            }
        }

        private void angleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPlugins.LoadAngle(this);
        }

        private void loadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPlugins.LoadAngle(this);
            LoadPlugins.LoadXmlJsonConverter("serialize.xml");
        }

        private void xmlJsonConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPlugins.LoadXmlJsonConverter("serialize.xml");
        }
    }
}
