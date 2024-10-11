using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace App4
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        Form2 form2;
        MiddleForm form3;   
        HardForm   form4;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (EasyRadioButton.Checked)
            {
                form2 = new Form2();
                form2.Show();
               // form2.Activate();
            }
            if (MiddleRadioButton.Checked) {
                form3 = new MiddleForm();
                form3.Show();
                //form3.Activate();
            }
            if (HardRadioButton.Checked) {
                form4 = new HardForm();
                form4.Show();
               // form4.Activate();
            }
        }
    }
}



//string TargetString = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
//int CurrentIndex, MaxCount = 10, count = 0;

//Graphics Graph;
//Font MyFont = new Font("Arial", 32);
//Random Rand = new Random();
//DateTime start;

//private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
//{
//    Graph.Dispose();
//    MyFont.Dispose();
//}
//private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
//{
//    if (((int)e.KeyChar == 13) && (count == 0))
//    {   //если нажат Enter и символы еще не выводились
//        start = DateTime.Now;   //запоминаем время начала
//                                //определяем номер символа в строке
//        CurrentIndex = Rand.Next(TargetString.Length);
//        //отображаем этот символ на форме
//        Graph.DrawString(TargetString.Substring(CurrentIndex, 1),
//        MyFont, Brushes.Black, 160, 75);
//        //увеличиваем количество выведенных символов
//        count = 1;
//        //изменяем заголовок
//        Text = "Нажми правильную клавишу!";
//    }
//    else if ((count > 0) && (e.KeyChar == TargetString[CurrentIndex]))
//    {   //если проверка началась и введен правильный символ
//        if (count == MaxCount) //если проверка закончилась
//        {
//            //определяем количество секунд с начала проверки
//            int time = DateTime.Now.Subtract(start).Seconds;
//            //выводим сообщение
//            MessageBox.Show("Время выполнения = " +
//            time.ToString() + " секунд");
//            Close();    //закрываем форму
//        }
//        else    //введен не последний символ
//        {
//            //очищаем форму цветом формы
//            Graph.Clear(BackColor);
//            //определяем номер символа в строке
//            CurrentIndex = Rand.Next(TargetString.Length);
//            //отображаем этот символ на форме
//            Graph.DrawString(TargetString[CurrentIndex].ToString(),
//            MyFont, Brushes.Black, 160, 75);
//            //увеличиваем количество выведенных символов
//            count++;
//        }
//    }
//    //если введен неверный символ,
//    //воспроизводим звуковой сигнал
//    else System.Media.SystemSounds.Hand.Play();

//}

//public MainForm()
//{
//    InitializeComponent();
//    Graph = CreateGraphics();
//}

//private void MainForm_Load(object sender, EventArgs e)
//{

//}
//    }