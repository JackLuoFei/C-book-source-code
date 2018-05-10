using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources._3;
        }
        private int imageNum = -1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % 3;
            switch (imageNum)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
            }
        }
    }
}
