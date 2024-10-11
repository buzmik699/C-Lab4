using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace App9
{
    public partial class MainForm : Form
    {
        int x, y, xa, ya, xb, yb, xc, yc;
        Graphics Graph;
        Pen MyPen;
        Random Rand;
        public MainForm()
        {
            InitializeComponent();
            MyPen = new Pen(Color.Blue, 2);
            Graph = CreateGraphics();
            Rand = new Random();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyPen.Dispose();
            Graph.Dispose();
        }
        private void ImagineButton_Click(object sender, EventArgs e)
        {
            Graph.Clear(BackColor);
            TextBox.Enabled = true;
            StartButton.Enabled = true;

            xa = Rand.Next(this.ClientSize.Width);
            ya = Rand.Next(this.ClientSize.Height);
            xb = Rand.Next(this.ClientSize.Width);
            yb = Rand.Next(this.ClientSize.Height);
            xc = Rand.Next(this.ClientSize.Width);
            yc = Rand.Next(this.ClientSize.Height);
            Graph.DrawLine(MyPen, xa, ya, xb, yb);
            Graph.DrawLine(MyPen, xb, yb, xc, yc);
            Graph.DrawLine(MyPen, xc, yc, xa, ya);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            TextBox.Enabled = false;
            StartButton.Enabled = false;
            int n = int.Parse(TextBox.Text), abc;

            Graph.DrawLine(MyPen, x, y, x, y);
            for(int i = 0; i < n; i++)
            {
                abc = Rand.Next(3);
                switch (abc) {
                    case 0:
                        {
                            x = (x + xa) / 2;
                            y = (y + ya) / 2;
                            break;
                        }
                    case 1:
                        {
                            x = (x + xb) / 2;
                            y = (y + yb) / 2;
                            break;
                        }
                    case 2:
                        {
                            x = (x + xc) / 2;
                            y = (y + yc) / 2;
                            break;
                        }
                }
                Graph.DrawLine(MyPen, x, y, x + 1, y + 1);
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;  
        }
    }
}
