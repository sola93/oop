using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //namespace of dialog forms
        private readonly string _dialog = "lab2.Dialogs.";
        private bool _startPaint;
        //open choosing dialog form
        private void button2_Click(object sender, EventArgs e)
        {
            Type selectedType = Type.GetType(_dialog + listBox1.SelectedItem + "Dialog");
            Form dialog = (Form)Activator.CreateInstance(selectedType ?? throw new InvalidOperationException());
            dialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _startPaint = true;
            Refresh();
        }

        private new void Paint(object sender, PaintEventArgs e)
        {
            if (_startPaint)
            {
                ShapesList.Accept(e.Graphics);
                _startPaint = false;
                Refresh();
            }
        }
    }
}
