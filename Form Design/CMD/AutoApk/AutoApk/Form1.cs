using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoApk
{
    public partial class AutoApkMain : Form
    {
        public AutoApkMain()
        {
            InitializeComponent();
        }

        private void AutoApkMain_Load(object sender, EventArgs e)
        {

        }

        private void RunCmd_Click(object sender, EventArgs e)
        {
            Cmd c = new Cmd();
            richTextBox1.Text = c.RunCmd(txtCmd.Text.Trim());

        }

        private void AutoApkMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void txtCmd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
