using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App8
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        Random Rand; 
        public MainForm()
        {
            InitializeComponent();
            Rand = new Random();
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы так и думали");
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
         
        }

        private void NoButton_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Rand.Next(this.ClientSize.Width);
            int y = Rand.Next(this.ClientSize.Height);
            if (x + NoButton.Width > this.ClientSize.Width) x -= NoButton.Width;
            if (y + NoButton.Height > this.ClientSize.Height) y -= NoButton.Height;
            if (x - NoButton.Width < 0) x += NoButton.Width;
            if (y - NoButton.Height < 0) y += NoButton.Height;
            NoButton.Location = new Point(x, y);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
