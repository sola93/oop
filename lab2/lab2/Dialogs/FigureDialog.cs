using System.Windows.Forms;

namespace lab2.Dialogs
{
    public abstract partial class FigureDialog : Form
    {
        protected FigureDialog()
        {
            InitializeComponent();
        }

        //Clean form after input
        public abstract void Clean();

        //Add Shape to List
        public abstract void AddShape();
    }
}
