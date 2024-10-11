using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App6
{
    public partial class MainForm : Form
    {
        IntroForm form2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MiddleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form2 = new IntroForm();
            if (Count1RadioButton.Checked) form2.count = 1;
            else if(Count2RadioButton.Checked) form2.count = 2;

            if (SlowRadioButton.Checked) form2.speed = 1;
            else if (MiddleRadioButton.Checked) form2.speed = 2;
            else if(FastRadioButton.Checked) form2.speed = 3;

            if(RictanglesRadioButton.Checked) form2.figure = 1;
            else if(AlipseRadioButton.Checked) form2.figure = 2;
            else if(RictAllRadioButton.Checked) form2.figure = 3; 
            form2.Show();
            form2.Activate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.OKCancel) == DialogResult.OK) { this.Close(); }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.OKCancel) == DialogResult.OK) { this.Close(); }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.OKCancel) == DialogResult.OK) { this.Close(); }
        }
    }
}
