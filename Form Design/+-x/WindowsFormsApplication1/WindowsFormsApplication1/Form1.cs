using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Decimal Num1, Num2,sum,dif,pro,quo;
        //public Decimal quo;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Num2 = Convert.ToDecimal(Num_2.Text);
            sum = Num1 + Num2; 
            dif = Num1 - Num2;
            pro = Num1 * Num2;
            quo = Num1 / Num2;
            textBox3.Text = Convert.ToString(sum);
            textBox4.Text = Convert.ToString(dif);
            textBox5.Text = Convert.ToString(pro);
            textBox6.Text = Convert.ToString(quo);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Num1 = Convert.ToDecimal(Num_1.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
