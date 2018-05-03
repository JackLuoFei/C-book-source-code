using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerOff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shutdown;
            Cmd c = new Cmd();
            shutdown="shutdown -s -t "+textBox1.Text;
            c.RunCmd(shutdown);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cmd c = new Cmd();
            c.RunCmd("shutdown -a");
        }
    }
}
