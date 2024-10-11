using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App6
{
    public partial class IntroForm : Form
    {
        DateTime sec;
        Graphics Graph;
        SolidBrush MyBrush1, MyBrush2;
        Random Rand = new Random();
        Pen MyPen;

        public int count, speed, figure;

        int x1, y1, x2, y2;
        int x, y;
        public IntroForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyBrush1 = new SolidBrush(Color.Red);
            MyBrush2 = new SolidBrush(Color.Yellow);
            MyPen = new Pen(Color.Green, 4);
            x = this.ClientSize.Width;
            y = this.ClientSize.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec.AddSeconds(1);
            if (sec.Second % 20 == 0)
            {
                Graph.Clear(BackColor);
                for (int i = 0; i < count; i++){
                    x1 = Rand.Next(x / 2) ; x2 = Rand.Next(x / 2) ; y1 = Rand.Next(y / 2) ; y2 = Rand.Next(y / 2) ;
                    if( x1 > x2 && x1 > x)
                    {
                        x1 = x1 - x2;
                    }
                    if(y1 > y2 && y1 > y)
                    {
                        y1 = y1 - y2;
                    }
                    if (x1 < x2 && x2 > x)
                    {
                        x2 = x2 - x1;
                    }
                    if (y1 < y2 && y2 > y)
                    {
                        y2 = y2 - y1;
                    }
                    switch (figure)
                            {
                                case 1:
                                    {
                                        Graph.DrawRectangle(MyPen, x1, y1, x2, y2);
                                Graph.FillRectangle(MyBrush1, x1, y1, x2, y2);
                                        break;
                                    }
                                case 2:
                                    {
                                Graph.DrawEllipse(MyPen, x1, y1, x2, y2);
                                Graph.FillEllipse(MyBrush2, x1, y1, x2, y2);
                                break;
                                    }
                                case 3:
                                    {
                                Graph.DrawEllipse(MyPen, x1, y1, x2, y2);
                                Graph.FillEllipse(MyBrush2, x1, y1, x2, y2);

                                x1 = Rand.Next(x); x2 = Rand.Next(x); y1 = Rand.Next(y); y2 = Rand.Next(y);
                                Graph.DrawRectangle(MyPen, x1, y1, x2, y2);
                                Graph.FillRectangle(MyBrush1, x1, y1, x2, y2);
                                break; 
                            }
                            }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec = sec.AddSeconds(1);
            if (sec.Second % 10 == 0)
            {
                Graph.Clear(BackColor);
                for (int i = 0; i < count; i++)
                {

                    x1 = Rand.Next(x / 2); x2 = Rand.Next(x / 2); y1 = Rand.Next(y / 2); y2 = Rand.Next(y / 2);
                    if (x1 > x2 && x1 > x)
                    {
                        x1 = x1 - x2;
                    }
                    if (y1 > y2 && y1 > y)
                    {
                        y1 = y1 - y2;
                    }
                    if (x1 < x2 && x2 > x)
                    {
                        x2 = x2 - x1;
                    }
                    if (y1 < y2 && y2 > y)
                    {
                        y2 = y2 - y1;
                    }

                    switch (figure)
                    {
                        case 1:
                            {
                                Graph.DrawRectangle(MyPen, x1, y1, x2, y2);
                                Graph.FillRectangle(MyBrush1, x1, y1, x2, y2);
                                break;
                            }
                        case 2:
                            {
                                Graph.DrawEllipse(MyPen, x1, y1, x2, y2);
                                Graph.FillEllipse(MyBrush2, x1, y1, x2, y2);
                                break;
                            }
                        case 3:
                            {
                                Graph.DrawEllipse(MyPen, x1, y1, x2, y2);
                                Graph.FillEllipse(MyBrush2, x1, y1, x2, y2);

                                x1 = Rand.Next(x); x2 = Rand.Next(x); y1 = Rand.Next(y); y2 = Rand.Next(y);
                                Graph.DrawRectangle(MyPen, x1, y1, x2, y2);
                                Graph.FillRectangle(MyBrush1, x1, y1, x2, y2);
                                break;
                            }
                    }
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sec = sec.AddSeconds(1);
            if (sec.Second % 5 == 0)
            {
                Graph.Clear(BackColor);
                for (int i = 0; i < count; i++)
                {
                    x1 = Rand.Next(x / 2); x2 = Rand.Next(x / 2); y1 = Rand.Next(y / 2); y2 = Rand.Next(y / 2);
                    if (x1 > x2 && x1 > x)
                    {
                        x1 = x1 - x2;
                    }
                    if (y1 > y2 && y1 > y)
                    {
                        y1 = y1 - y2;
                    }
                    if (x1 < x2 && x2 > x)
                    {
                        x2 = x2 - x1;
                    }
                    if (y1 < y2 && y2 > y)
                    {
                        y2 = y2 - y1;
                    }
                    switch (figure)
                    {
                        case 1:
                            {
                                Graph.DrawRectangle(MyPen, x1, y1, x2, y2);
                                Graph.FillRectangle(MyBrush1, x1, y1, x2, y2);
                                break;
                            }
                        case 2:
                            {
                                Graph.DrawEllipse(MyPen, x1, y1, x2, y2);
                                Graph.FillEllipse(MyBrush2, x1, y1, x2, y2);
                                break;
                            }
                        case 3:
                            {
                                Graph.DrawEllipse(MyPen, x1, y1, x2, y2);
                                Graph.FillEllipse(MyBrush2, x1, y1, x2, y2);

                                x1 = Rand.Next(x); x2 = Rand.Next(x); y1 = Rand.Next(y); y2 = Rand.Next(y);
                                Graph.DrawRectangle(MyPen, x1, y1, x2, y2);
                                Graph.FillRectangle(MyBrush1, x1, y1, x2, y2);
                                break;
                            }
                    }
                }
            }
        }
        

        private void IntroForm_Activated(object sender, EventArgs e)
        {
            sec = new DateTime();
            if (speed == 1)
            {
                timer1.Enabled = true;
            }
            else if (speed == 2)
            {
                timer2.Enabled = true;
            }
            else if (speed == 3)
            {
                timer3.Enabled = true;
            }
            
        }

       

        private void IntroForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               Application.Exit();
            }
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
        }
        private void IntroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Graph.Dispose();
            MyBrush1.Dispose();
            MyBrush2.Dispose();
            MyPen.Dispose();
        }
    }
}
