using System;
using System.Windows.Forms;

using NumbersProjekt.controller;

namespace NumbersProjekt
{
    public partial class NumbersForm : Form
    {
        private NumbersController nc;

        public NumbersForm()
        {
            nc = new NumbersController();
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
