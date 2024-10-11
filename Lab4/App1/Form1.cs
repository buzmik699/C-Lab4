using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            double data = 0;
            try
            {
                if (dm.Checked)
                {
                    data = double.Parse(CentiMTextBox.Text) * 2.54;
                }
                if (yr.Checked)
                {
                    data = double.Parse(CentiMTextBox.Text) * 91.44;
                }
                if (ft.Checked)
                {
                    data = double.Parse(CentiMTextBox.Text) * 30.48;
                }
                if (mt.Checked)
                {
                    data = double.Parse(CentiMTextBox.Text) * 100;
                }
                if (sm.Checked) data = double.Parse(CentiMTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (InchRadioButton.Checked)
                    ResultTextBox.Text =
                    (data / 2.54).ToString();
                if (YardRadioButton.Checked)
                    ResultTextBox.Text =
                    (data / 91.44).ToString();
                if (FootRadioButton.Checked)
                    ResultTextBox.Text =
                    (data / 30.48).ToString();
                if (SanButton.Checked) ResultTextBox.Text =
                    (data).ToString();
                if (MetrButton.Checked) ResultTextBox.Text =
                    (data / 100).ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                CentiMTextBox.Text = "0";
                ResultTextBox.Text = "0";
            }

        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}