using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class MainForm : Form
    {
        int x, y;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            x = this.ClientSize.Width;
            y = this.ClientSize.Height;
            ExecuteButton.Location = new Point(x - 10 - ExecuteButton.Width, y - 10 - ExecuteButton.Height);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            x = this.ClientSize.Width;
            y = this.ClientSize.Height;
            ExecuteButton.Location = new Point(x - 10 - ExecuteButton.Width, y - 10 - ExecuteButton.Height);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool fl = false;
                string s1 = (CentiMTextBox.Text).ToString() + " 00:00 AM";
                DateTime start = DateTime.Parse(s1);
                string s2 = "";
                for (int i = 9; i > 5; i--)
                {
                    if (s1[i] - 48 == 9 && i > 5)
                    {
                        s2 = "0" + s2;
                        fl = true;
                    }
                    else if (fl && i > 5)
                    {
                        s2 = (s1[i] + 1) + s2;
                    }
                    else if(i == 9)
                    {
                        s2 =  ((char) (s1[i] + 1) + s2);
                    }
                    else s2 = s1[i] + s2;
                }
                s2 = "01/01/" + s2 + " 00:00 AM";
                DateTime end = DateTime.Parse(s2);
                ResultTextBox.Text = ((end - start).TotalDays - 1).ToString(); // -1
            }
            catch
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
