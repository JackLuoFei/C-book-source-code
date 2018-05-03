using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_1
{
    public partial class Form1 : Form
    {
        public string [] temp_string;
        public string temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            //temp = textBox_Input.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            temp = textBox2.Text;
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (textBox2.Text[i] >= 'a' && textBox2.Text[i] <= 'z')
                    temp = temp+32;
            }
                textBox_Input.Text = temp;
           //textBox2.Text = temp;
        }
    }
}
