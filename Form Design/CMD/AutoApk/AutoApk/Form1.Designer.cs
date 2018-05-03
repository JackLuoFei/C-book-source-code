namespace AutoApk
{
    partial class AutoApkMain
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
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.RunCmd = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(35, 35);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(453, 21);
            this.txtCmd.TabIndex = 0;
            this.txtCmd.TextChanged += new System.EventHandler(this.txtCmd_TextChanged);
            // 
            // RunCmd
            // 
            this.RunCmd.Location = new System.Drawing.Point(535, 33);
            this.RunCmd.Name = "RunCmd";
            this.RunCmd.Size = new System.Drawing.Size(75, 23);
            this.RunCmd.TabIndex = 1;
            this.RunCmd.Text = "RunCmd";
            this.RunCmd.UseVisualStyleBackColor = true;
            this.RunCmd.Click += new System.EventHandler(this.RunCmd_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(701, 380);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // AutoApkMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 471);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.RunCmd);
            this.Controls.Add(this.txtCmd);
            this.Name = "AutoApkMain";
            this.Text = "自动生成Apk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoApkMain_FormClosing);
            this.Load += new System.EventHandler(this.AutoApkMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.Button RunCmd;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

