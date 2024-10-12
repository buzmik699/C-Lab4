using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace App4
{
    public partial class HardForm : System.Windows.Forms.Form
    {
        string TargetString = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int CurrentIndex, MaxCount = 10, count = 0, right = 0, missed = 0;
        Graphics Graph;
        Font MyFont = new Font("Arial", 32);
        Random Rand = new Random();
        DateTime start;
        Timer timer;


        public HardForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            missed++;
            if (count == MaxCount)
            {
                timer.Stop();
                int time = DateTime.Now.Subtract(start).Seconds; //прошло сек от старт
                InfoLabel.Text = $"Время выполнения = {time} секунд\nИз {MaxCount} букв\nСделано ошибок: {count - right}\nПропущено букв: {missed}";
                return;
            }
            Graph.Clear(BackColor);
            CurrentIndex = Rand.Next(TargetString.Length);
            Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
            count++;
            timer.Start();
        }

        private void HardForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer.Stop();

            if (((int)e.KeyChar == 13) && (count == 0))
            {
                start = DateTime.Now;
                Graph.Clear(BackColor);
                CurrentIndex = Rand.Next(TargetString.Length);
                Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
                count = 1;
                Text = "Нажми правильную клавишу!";
                timer.Start();
            }
            else if (count > 0)
            {
                if (count < MaxCount)
                {
                    if (e.KeyChar == TargetString[CurrentIndex])
                    {
                        right++;
                    }
                    Graph.Clear(BackColor);
                    CurrentIndex = Rand.Next(TargetString.Length);
                    Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
                    count++;
                    timer.Start();
                }
                else //конец игры
                {
                    if (e.KeyChar == TargetString[CurrentIndex])
                    {
                        right++;
                    }
                    int time = DateTime.Now.Subtract(start).Seconds; //прошло сек от старт
                    InfoLabel.Text = $"Время выполнения = {time} секунд\nИз {MaxCount} букв\nСделано ошибок: {count - right}\nПропущено букв: {missed}";
                    timer.Stop();
                    count = -1;
                    return;
                }
            }
        }

        private void HardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Graph.Dispose();
            MyFont.Dispose();
            timer.Dispose();
        }
    }
}
