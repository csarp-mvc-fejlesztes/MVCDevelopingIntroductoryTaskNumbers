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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            nc.addNumber(textBoxNumber.Text);
            listBoxNumber.DataSource = nc.getNumbers();
            textBoxNumber.Text = string.Empty;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int index = listBoxNumber.SelectedIndex;
            nc.modifyNumber(index, textBoxNumber.Text);
            listBoxNumber.DataSource = null;
            listBoxNumber.DataSource = nc.getNumbers();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxNumber.SelectedIndex;
            nc.deleteNumber(index);
            listBoxNumber.DataSource = null;
            listBoxNumber.DataSource = nc.getNumbers();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            textBoxAverage.Text = nc.computeAverage();
        }
    }
}
