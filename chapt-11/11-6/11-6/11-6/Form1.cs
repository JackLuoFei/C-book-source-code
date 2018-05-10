using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_6
{
    public partial class Form1 : Form
    {
        private Color pickedColor;
        private Point old;
        private bool capture = false;

        public Form1()
        {
            InitializeComponent();
            pickedColor = this.BackColor;
        }

        private void panel_Red_MouseEnter(object sender, EventArgs e)
        {
            pickedColor = Color.Red;
            //panel_Draw_Zone.BackColor = pickedColor;
            panel_Now.BackColor = pickedColor;
        }

        private void panel_Yellow_MouseEnter(object sender, EventArgs e)
        {
            pickedColor = Color.Yellow;
            //panel_Draw_Zone.BackColor = pickedColor;
            panel_Now.BackColor = pickedColor;
        }

        private void panel_Blue_MouseEnter(object sender, EventArgs e)
        {
            pickedColor = Color.Blue;
            //panel_Draw_Zone.BackColor = pickedColor;
            panel_Now.BackColor = pickedColor;
        }

        private void panel_Draw_Zone_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                capture = true;
                old = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                capture = false;

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (capture)
            {
                using (Graphics g = CreateGraphics())
                {
                    Pen pen = new Pen(pickedColor);
                    g.DrawLine(pen, old, e.Location);
                    old = e.Location;
                }
            }

            xValue.Text = e.Location.X.ToString();
            yValue.Text = e.Location.Y.ToString();
             
        }
        

        private void panel_Now_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Now_MouseHover(object sender, EventArgs e)
        {
            pickedColor = this.BackColor;
            panel_Now.BackColor = pickedColor;
            using (Graphics g = CreateGraphics())
            {
                g.Clear(pickedColor);
            }
        }

        private void panel_Red_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Draw_Zone_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel_Draw_Zone_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel_Draw_Zone_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel_Draw_Zone_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

    }
}
