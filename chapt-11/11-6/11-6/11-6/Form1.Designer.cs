namespace _11_6
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Red = new System.Windows.Forms.Panel();
            this.panel_Yellow = new System.Windows.Forms.Panel();
            this.panel_Blue = new System.Windows.Forms.Panel();
            this.xValue = new System.Windows.Forms.TextBox();
            this.yValue = new System.Windows.Forms.TextBox();
            this.panel_Now = new System.Windows.Forms.Panel();
            this.panel_Draw_Zone = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_Red
            // 
            this.panel_Red.BackColor = System.Drawing.Color.Red;
            this.panel_Red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Red.Location = new System.Drawing.Point(9, 13);
            this.panel_Red.Name = "panel_Red";
            this.panel_Red.Size = new System.Drawing.Size(45, 49);
            this.panel_Red.TabIndex = 1;
            this.panel_Red.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Red_Paint);
            this.panel_Red.MouseEnter += new System.EventHandler(this.panel_Red_MouseEnter);
            // 
            // panel_Yellow
            // 
            this.panel_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.panel_Yellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Yellow.Location = new System.Drawing.Point(88, 13);
            this.panel_Yellow.Name = "panel_Yellow";
            this.panel_Yellow.Size = new System.Drawing.Size(45, 49);
            this.panel_Yellow.TabIndex = 2;
            this.panel_Yellow.MouseEnter += new System.EventHandler(this.panel_Yellow_MouseEnter);
            // 
            // panel_Blue
            // 
            this.panel_Blue.BackColor = System.Drawing.Color.Blue;
            this.panel_Blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Blue.Location = new System.Drawing.Point(167, 13);
            this.panel_Blue.Name = "panel_Blue";
            this.panel_Blue.Size = new System.Drawing.Size(45, 49);
            this.panel_Blue.TabIndex = 3;
            this.panel_Blue.MouseEnter += new System.EventHandler(this.panel_Blue_MouseEnter);
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(218, 11);
            this.xValue.Name = "xValue";
            this.xValue.ReadOnly = true;
            this.xValue.Size = new System.Drawing.Size(73, 21);
            this.xValue.TabIndex = 5;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(218, 42);
            this.yValue.Name = "yValue";
            this.yValue.ReadOnly = true;
            this.yValue.Size = new System.Drawing.Size(73, 21);
            this.yValue.TabIndex = 6;
            // 
            // panel_Now
            // 
            this.panel_Now.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Now.Location = new System.Drawing.Point(302, 13);
            this.panel_Now.Name = "panel_Now";
            this.panel_Now.Size = new System.Drawing.Size(45, 49);
            this.panel_Now.TabIndex = 7;
            this.panel_Now.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Now_Paint);
            this.panel_Now.MouseHover += new System.EventHandler(this.panel_Now_MouseHover);
            // 
            // panel_Draw_Zone
            // 
            this.panel_Draw_Zone.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Draw_Zone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Draw_Zone.Location = new System.Drawing.Point(0, 1);
            this.panel_Draw_Zone.Name = "panel_Draw_Zone";
            this.panel_Draw_Zone.Size = new System.Drawing.Size(353, 84);
            this.panel_Draw_Zone.TabIndex = 0;
            this.panel_Draw_Zone.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Draw_Zone_Paint);
            this.panel_Draw_Zone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_Zone_MouseDown);
            this.panel_Draw_Zone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_Zone_MouseMove);
            this.panel_Draw_Zone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_Zone_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 348);
            this.Controls.Add(this.panel_Now);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.panel_Blue);
            this.Controls.Add(this.panel_Yellow);
            this.Controls.Add(this.panel_Red);
            this.Controls.Add(this.panel_Draw_Zone);
            this.Name = "Form1";
            this.Text = "11-6";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Red;
        private System.Windows.Forms.Panel panel_Yellow;
        private System.Windows.Forms.Panel panel_Blue;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.Panel panel_Now;
        private System.Windows.Forms.Panel panel_Draw_Zone;
    }
}

