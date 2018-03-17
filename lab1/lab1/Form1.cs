using lab1.Shapes;
using System;
using System.Drawing;
using System.Windows.Forms;
using lab1.Visitor;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shapeslist.AddShape(new Circle(new Point(30, 30), 20));
            Shapeslist.AddShape(new Ellipse(new Point(60, 50), 50, 30));
            Shapeslist.AddShape(new Square(new Point(130, 100), 50));
            Shapeslist.AddShape(new Shapes.Rectangle(new Point(200, 100), 20, 80));
            Shapeslist.AddShape(new Segment(new Point(240, 30), new Point(260, 70)));
            Shapeslist.AddShape(new Triangle(new Point(300, 30), new Point(280, 100), new Point(320, 70)));
            foreach (var t in Shapeslist.List)
            {
                listBox1.Items.Add(t.ToString());
            }
            listBox1.Enabled = false;
        }

        private bool _startPaint;

        private void button1_Click(object sender, EventArgs e)
        {
            _startPaint = true;
            Refresh();
        }

        private new void Paint(object sender, PaintEventArgs e)
        {
            if (_startPaint)
            {
                Shapeslist.Accept(new DrawVisitor(), e.Graphics);
                _startPaint = false;
                Refresh();
            }
        }
    }
}
