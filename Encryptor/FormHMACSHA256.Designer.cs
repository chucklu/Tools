namespace Encryptor
{
    partial class FormHMACSHA256
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxSecretKey = new System.Windows.Forms.GroupBox();
            this.textBoxSecretKey = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxSecretKey.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(878, 156);
            this.textBoxInput.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.splitter1);
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(884, 175);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(3, 169);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(878, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBoxSecretKey
            // 
            this.groupBoxSecretKey.Controls.Add(this.textBoxSecretKey);
            this.groupBoxSecretKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSecretKey.Location = new System.Drawing.Point(0, 175);
            this.groupBoxSecretKey.Name = "groupBoxSecretKey";
            this.groupBoxSecretKey.Size = new System.Drawing.Size(884, 41);
            this.groupBoxSecretKey.TabIndex = 2;
            this.groupBoxSecretKey.TabStop = false;
            this.groupBoxSecretKey.Text = "SecretKey";
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSecretKey.Location = new System.Drawing.Point(3, 16);
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(878, 20);
            this.textBoxSecretKey.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(0, 263);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(884, 299);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(878, 280);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(174, 222);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(68, 35);
            this.buttonCompute.TabIndex = 4;
            this.buttonCompute.Text = "计算";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(548, 222);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(68, 35);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "清屏";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormHMACSHA256
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxSecretKey);
            this.Controls.Add(this.groupBoxInput);
            this.Name = "FormHMACSHA256";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HMACSHA256";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxSecretKey.ResumeLayout(false);
            this.groupBoxSecretKey.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxSecretKey;
        private System.Windows.Forms.TextBox textBoxSecretKey;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Button buttonClear;
    }
}