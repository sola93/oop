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
            foreach(var t in Shapeslist.list)
            {
                listBox1.Items.Add(t.ToString());
            }
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
                Shapeslist.list[number].Accept(new DrawVisitor(), e.Graphics);
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
