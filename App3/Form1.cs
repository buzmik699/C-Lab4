using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class MainForm : Form
    {
        double k, a, h;
        public MainForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CurrentBox_Click(object sender, EventArgs e)
        {
            if (Man.Checked)
            {
                k = 1;
            }
            else
            {
                k = 0.9;
            }
            try
            {
                a = int.Parse(AgeBox.Text);
                h = int.Parse(HeightBox.Text);
                if (a < 15 || a > 80 || h < 120 || h > 200)
                {
                    throw new Exception();
                }
                ResultTextBox.Text =
                    (k * (50 + 0.75 * (h - 150) + 0.25 * (a - 20))).ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
