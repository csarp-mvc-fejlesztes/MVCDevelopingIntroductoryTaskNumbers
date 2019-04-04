using System;
using System.Windows.Forms;

namespace NumbersProjekt
{
    public partial class NumbersForm : Form
    {
        public NumbersForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
