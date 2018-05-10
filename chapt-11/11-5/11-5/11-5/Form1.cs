using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal princial = Convert.ToDecimal(textBox1.Text);
            decimal rate = Convert.ToDecimal(textBox2.Text);
            int year = (int)numericUpDown1.Value;

            decimal sum = princial * rate * year+princial;
            //textBox3.Text = Convert.ToString(sum);
            textBox3.Text = sum.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
