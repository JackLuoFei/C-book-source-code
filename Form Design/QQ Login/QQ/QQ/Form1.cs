using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ
{
    public partial class QQ : Form
    {
        public QQ()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //https://ssl.ptlogin2.qq.com/qq_signup?pt_clientver=5563&pt_src=1&ptlang=2052&regkey=62C230673FEDC56D0FD4744F87F4DDEB35847D204CB5C7EC799246281450E6A9&ADUIN=0&ADSESSION=0&ADTAG=CLIENT.QQ.5563_NewAccount_Btn.0&ADPUBNO=26785
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (QQ_password.Text =="密码不能为空")
                QQ_password.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(TextBox QQ.QQ_number==0)
            if(QQ_password.Text == "")
                QQ_password.Text="密码不能为空";
            if (QQ_number.Text == "")
                QQ_number.Text = "账号不能为空";
        }

    }
}
