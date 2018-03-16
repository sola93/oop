using lab1.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (var t in Shapeslist.list)
            {
                listBox1.Items.Add(t.ToString());
            }
            listBox1.Enabled = false;
        }

        private bool start_paint;
        private int number;

        private void button1_Click(object sender, EventArgs e)
        {
            start_paint = true;
            Refresh();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            if (start_paint)
            {
                Shapeslist.Accept(new DrawVisitor(), e.Graphics);
                start_paint = false;
                Refresh();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            number = listBox1.SelectedIndex;
        }
    }
}
