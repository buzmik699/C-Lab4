using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace App7
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        DateTime sec;
        Random Rand;
        Font MyFont;
        int x, y;
        int x1, y1, mx, my;
        int eat = 0;

        Graphics Graph;
        public MainForm()
        {
            InitializeComponent();
            Rand = new Random();
            x = this.ClientSize.Width;
            y = this.ClientSize.Height;
            Graph = CreateGraphics();
            MyFont = new Font("Arial", 11);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы собрали " + eat.ToString() + " кусков сыра.\nХотите играть снова?", "Игра окончена", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MouseBox.Location = new Point(350, 321);
                CheezeBox.Location = new Point(12, 12); 
                e.Cancel = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            mx = MouseBox.Location.X;
            my = MouseBox.Location.Y;
            timer1.Enabled = true;  
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 68 && mx + 10 + MouseBox.ClientSize.Width < x)
            {
                mx += 10;
               Graph.Clear(BackColor);
            }

            if ((int)e.KeyCode == 65 && mx - 10 > 0)
            {
                mx -= 10;
               Graph.Clear(BackColor);
            }

            if ((int)e.KeyCode == 83 && my + 10 + MouseBox.ClientSize.Height < y)
            {
                my += 10;
               Graph.Clear(BackColor);
            }

            if ((int)e.KeyCode == 87 && my - 10  > 0)
            {
                my -= 10;
               Graph.Clear(BackColor);
            }
            MouseBox.Location = new Point(mx, my);

            if (Math.Abs(x1 - mx) < CheezeBox.Width / 2 && Math.Abs(y1 - my) < CheezeBox.Height /2)
            {
                eat++;
                x1 = Rand.Next(x);
                y1 = Rand.Next(y);

                if (x1 + CheezeBox.Width > this.ClientSize.Width) x1 -= CheezeBox.Width;
                if (y1 + CheezeBox.Height > this.ClientSize.Height) y1 -= CheezeBox.Height;
                if (x1 - CheezeBox.Width < 0) x1 += CheezeBox.Width;
                if (y1 - CheezeBox.Height < 0) y1 += CheezeBox.Height;

                Graph.DrawString("Вы cъели сыр", MyFont, Brushes.Black, 50, 50);
                

                CheezeBox.Location = new Point(x1, y1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec.AddSeconds(1);
            if(sec.Second == 0)
            {
                timer1.Enabled = false;
                Close();
                sec = new DateTime();
            }
            else if (sec.Second % 3 == 0)
            {
                x1 = Rand.Next(x);
                y1 = Rand.Next(y);

                if (x1 + CheezeBox.Width > this.ClientSize.Width) x1 -= CheezeBox.Width;
                if (y1 + CheezeBox.Height > this.ClientSize.Height) y1 -= CheezeBox.Height;
                if (x1 - CheezeBox.Width < 0) x1 += CheezeBox.Width;
                if (y1 - CheezeBox.Height < 0) y1 += CheezeBox.Height;

                CheezeBox.Location = new Point(x1, y1);
            }
        }
    }
}
