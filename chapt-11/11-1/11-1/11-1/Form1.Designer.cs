namespace _11_1
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
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Input = new System.Windows.Forms.Label();
            this.label_CopyInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(36, 36);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(210, 21);
            this.textBox_Input.TabIndex = 0;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.Location = new System.Drawing.Point(33, 15);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(89, 12);
            this.label_Input.TabIndex = 2;
            this.label_Input.Text = "输入的大写字母";
            // 
            // label_CopyInput
            // 
            this.label_CopyInput.AutoSize = true;
            this.label_CopyInput.Location = new System.Drawing.Point(36, 93);
            this.label_CopyInput.Name = "label_CopyInput";
            this.label_CopyInput.Size = new System.Drawing.Size(101, 12);
            this.label_CopyInput.TabIndex = 3;
            this.label_CopyInput.Text = "转换后的小写字母";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_CopyInput);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_Input);
            this.Name = "Form1";
            this.Text = "大写字母转换成小写字母";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.Label label_CopyInput;
    }
}

