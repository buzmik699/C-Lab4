using System;
using System.Windows.Forms;

namespace Ex1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InchTextBox.Text = (double.Parse(CentiMTextBox.Text)
                / 2.54).ToString();
                Fut.Text = (double.Parse(InchTextBox.Text)
                / 12).ToString();
                Yard.Text = (double.Parse(Fut.Text)
                / 3).ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CentiMTextBox.Text = "0";
                InchTextBox.Text = "0";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ExecuteButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
