using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        string TargetString = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int CurrentIndex, MaxCount = 10, count = 0, right = 0;

        Graphics Graph;
        Font MyFont = new Font("Arial", 32);
        Random Rand = new Random();
        DateTime start;


        public Form2()
        {
            InitializeComponent();
            Graph = CreateGraphics();
        }


        private void Form2_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (((int)e.KeyChar == 13) && (count == 0))
            {   //если нажат Enter и символы еще не выводились
                start = DateTime.Now;   //запоминаем время начала
                                        //определяем номер символа в строке
                CurrentIndex = Rand.Next(TargetString.Length);
                //отображаем этот символ на форме
                Graph.DrawString(TargetString.Substring(CurrentIndex, 1),
                MyFont, Brushes.Black, 160, 75);
                //увеличиваем количество выведенных символов
                count = 1;
                //изменяем заголовок
                Text = "Нажми правильную клавишу!";
            }
            else if ((count > 0))
            {   //если проверка началась и введен правильный символ
                if (count == MaxCount) //если проверка закончилась
                {
                    //определяем количество секунд с начала проверки
                    int time = DateTime.Now.Subtract(start).Seconds;
                    //выводим сообщение
                    InfoLabel.Text = "Время выполнения = " +
                    time.ToString() + " секунд\n" + "Сделано ошибок(пропущено букв): " + (count - right).ToString(); 
                    //Close();    //закрываем форму
                }
                else   //введен не последний символ
                {
                    if (e.KeyChar == TargetString[CurrentIndex])
                    {
                        right++;
                    }
                    //если введен неверный символ,
                    //воспроизводим звуковой сигнал
                    else
                    {
                        System.Media.SystemSounds.Hand.Play();
                    }
                    //очищаем форму цветом формы
                    Graph.Clear(BackColor);
                    //определяем номер символа в строке
                    CurrentIndex = Rand.Next(TargetString.Length);
                    //отображаем этот символ на форме
                    Graph.DrawString(TargetString[CurrentIndex].ToString(),
                    MyFont, Brushes.Black, 160, 75);
                    //увеличиваем количество выведенных символов
                    count++;
                }
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Graph.Dispose();
            MyFont.Dispose();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
