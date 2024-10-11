using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class MainForm : Form
    {
        DateTime Seconds;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //изменяем активность кнопок
            StopButton.Enabled = true;
            StartButton.Enabled = false;
            Seconds = new DateTime();	          //обнуляем счетчик секунд
            timer1.Enabled = true;  //запускаем Timer
                                    //выводим значение секундомера в метке 
            TimeLabel.Text = Seconds.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Seconds++;  //увеличиваем счетчик секунд
            //            //отображаем изменения в метке
            //TimeLabel.Text = Seconds.ToString();
            //увеличиваем значение секундомера на 1 секунду
            Seconds = Seconds.AddSeconds(1);
            TimeLabel.Text = Seconds.ToLongTimeString(); //отображаем изменения 
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //изменяем активность кнопок
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            timer1.Enabled = false;
        }
    }
}
