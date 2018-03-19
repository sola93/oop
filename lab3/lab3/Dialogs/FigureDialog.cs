using System;
using System.Windows.Forms;
using lab3.Shapes;

namespace lab3.Dialogs
{
    public abstract partial class FigureDialog : Form
    {
        public Figure Figure;
        protected FigureDialog()
        {
            InitializeComponent();
        }

        public abstract void AddShape();
        public abstract void EditShape(Figure figure);
        public abstract void Clean();
    }
}
