namespace Encryptor
{
    partial class FormWinCrc16
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonCrc16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(56, 44);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(474, 327);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(56, 458);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(474, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(54, 427);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(163, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "输出(十六进制表示的2个字节)";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(54, 22);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(133, 13);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "输入(十六进制的字符串)";
            // 
            // buttonCrc16
            // 
            this.buttonCrc16.Location = new System.Drawing.Point(55, 385);
            this.buttonCrc16.Name = "buttonCrc16";
            this.buttonCrc16.Size = new System.Drawing.Size(75, 25);
            this.buttonCrc16.TabIndex = 4;
            this.buttonCrc16.Text = "校验";
            this.buttonCrc16.UseVisualStyleBackColor = true;
            this.buttonCrc16.Click += new System.EventHandler(this.buttonCrc16_Click);
            // 
            // FormWinCrc16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 517);
            this.Controls.Add(this.buttonCrc16);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInput);
            this.Name = "FormWinCrc16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CRC-16 (Modbus)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonCrc16;
    }
}

