using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App5
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        double a, b, c;
        double x1, x2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CurrentBox_Click(object sender, EventArgs e)
        {
            double D;
            a = int.Parse(ABox.Text);
            b = int.Parse(BBox.Text);  
            c = int.Parse(CBox.Text);
            D = b * b - 4 * a * c;
            if(a == 0 && b == 0 && c != 0)
            {
                MessageBox.Show("Нет корней", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (a == 0)
            {
                x1 = (double)(-c / b); x2 = 0;
                x2 = x1;
            }
            else if (D > 0)
            {
                x1 = (double)((-b + Math.Sqrt(D)) / (2 * a));
                x2 = (double)((-b - Math.Sqrt(D)) / (2 * a));
            }

            else if (D == 0)
            {
                x1 = (double)((-b - Math.Sqrt(D)) / (2 * a));
                x2 = x1;
            }

            else if (D < 0) MessageBox.Show("Нет корней", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            X1ResultTextBox.Text = x1.ToString();
            X2ResultTextBox.Text = x2.ToString();
        }
    }
}
