using System;
using System.Windows.Forms;

using NumbersProjekt.controller;
using System.Diagnostics;

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
            try
            {
                nc.addNumber(textBoxNumber.Text);
                listBoxNumber.DataSource = nc.getNumbers();
                textBoxNumber.Text = string.Empty;
                textBoxNumber.Focus();
            }
            catch (ControllerException ce)
            {
                errorProviderAdd.SetError(buttonAdd, ce.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            if (listBoxNumber.Items.Count > 0)
                felfedPaneleket();
            else
                eltakarPaneleket();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int index = listBoxNumber.SelectedIndex;
            try
            {
                nc.modifyNumber(index, textBoxNumber.Text);
                listBoxNumber.DataSource = null;
                listBoxNumber.DataSource = nc.getNumbers();
            }
            catch (ControllerException ce)
            {
                errorProviderAdd.SetError(buttonModify, ce.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            if (listBoxNumber.Items.Count > 0)
                felfedPaneleket();
            else
                eltakarPaneleket();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxNumber.SelectedIndex;
            try
            {
                nc.deleteNumber(index);
                listBoxNumber.DataSource = null;
                listBoxNumber.DataSource = nc.getNumbers();
                if (listBoxNumber.Items.Count == 0)
                    textBoxNumber.Text = string.Empty;
            }
            catch (ControllerException ce)
            {
                errorProviderAdd.SetError(buttonDelete, ce.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            //computeAverage() nem dob kivételt
            textBoxAverage.Text = nc.computeAverage();
        }

        private void listBoxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //a listBox-ban kiválasztot elem legyen a TextBox-ban is
            int index = listBoxNumber.SelectedIndex;
            if (index < 0)
                return;
            textBoxNumber.Text = listBoxNumber.SelectedItem.ToString();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            errorProviderAdd.Clear();
            errorProviderDelete.Clear();
            errorProviderModify.Clear();
            errorProviderNumber.Clear();
        }

        private void NumbersForm_Load(object sender, EventArgs e)
        {
            eltakarPaneleket();
        }

        private void eltakarPaneleket()
        {
            panelCompute.Visible = false;
            panelNumber.Visible = false;
            textBoxNumber.Focus();
        }

        private void felfedPaneleket()
        {
            panelCompute.Visible = true;
            panelNumber.Visible = true;
        }
    }
}
