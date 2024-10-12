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
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (EasyRadioButton.Checked)
            {
                form2 = new Form2();
                form2.Show();
            }
            if (MiddleRadioButton.Checked) {
                form3 = new MiddleForm();
                form3.Show();
            }
            if (HardRadioButton.Checked) {
                form4 = new HardForm();
                form4.Show();
            }
        }
    }
}
