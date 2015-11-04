namespace UnixTime
{
    partial class FormMain
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
            this.textBoxTimeToSeconds = new System.Windows.Forms.TextBox();
            this.dateTimePickerCurrent = new System.Windows.Forms.DateTimePicker();
            this.buttonTimeToSeconds = new System.Windows.Forms.Button();
            this.buttonClearSeconds = new System.Windows.Forms.Button();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.buttonSecondsToTime = new System.Windows.Forms.Button();
            this.textBoxSecondsToTime = new System.Windows.Forms.TextBox();
            this.buttonClearTime = new System.Windows.Forms.Button();
            this.dateTimePickerBasic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTimeToSeconds
            // 
            this.textBoxTimeToSeconds.Location = new System.Drawing.Point(23, 94);
            this.textBoxTimeToSeconds.Multiline = true;
            this.textBoxTimeToSeconds.Name = "textBoxTimeToSeconds";
            this.textBoxTimeToSeconds.ReadOnly = true;
            this.textBoxTimeToSeconds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTimeToSeconds.Size = new System.Drawing.Size(424, 115);
            this.textBoxTimeToSeconds.TabIndex = 0;
            // 
            // dateTimePickerCurrent
            // 
            this.dateTimePickerCurrent.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerCurrent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCurrent.Location = new System.Drawing.Point(23, 47);
            this.dateTimePickerCurrent.Name = "dateTimePickerCurrent";
            this.dateTimePickerCurrent.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerCurrent.TabIndex = 1;
            // 
            // buttonTimeToSeconds
            // 
            this.buttonTimeToSeconds.Location = new System.Drawing.Point(257, 48);
            this.buttonTimeToSeconds.Name = "buttonTimeToSeconds";
            this.buttonTimeToSeconds.Size = new System.Drawing.Size(75, 23);
            this.buttonTimeToSeconds.TabIndex = 2;
            this.buttonTimeToSeconds.Text = "确定";
            this.buttonTimeToSeconds.UseVisualStyleBackColor = true;
            this.buttonTimeToSeconds.Click += new System.EventHandler(this.buttonTimeToSeconds_Click);
            // 
            // buttonClearSeconds
            // 
            this.buttonClearSeconds.Location = new System.Drawing.Point(372, 47);
            this.buttonClearSeconds.Name = "buttonClearSeconds";
            this.buttonClearSeconds.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSeconds.TabIndex = 3;
            this.buttonClearSeconds.Text = "清屏";
            this.buttonClearSeconds.UseVisualStyleBackColor = true;
            this.buttonClearSeconds.Click += new System.EventHandler(this.buttonClearSeconds_Click);
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(23, 245);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(200, 21);
            this.textBoxSeconds.TabIndex = 4;
            // 
            // buttonSecondsToTime
            // 
            this.buttonSecondsToTime.Location = new System.Drawing.Point(246, 245);
            this.buttonSecondsToTime.Name = "buttonSecondsToTime";
            this.buttonSecondsToTime.Size = new System.Drawing.Size(75, 23);
            this.buttonSecondsToTime.TabIndex = 5;
            this.buttonSecondsToTime.Text = "确定";
            this.buttonSecondsToTime.UseVisualStyleBackColor = true;
            this.buttonSecondsToTime.Click += new System.EventHandler(this.buttonSecondsToTime_Click);
            // 
            // textBoxSecondsToTime
            // 
            this.textBoxSecondsToTime.Location = new System.Drawing.Point(23, 287);
            this.textBoxSecondsToTime.Multiline = true;
            this.textBoxSecondsToTime.Name = "textBoxSecondsToTime";
            this.textBoxSecondsToTime.ReadOnly = true;
            this.textBoxSecondsToTime.Size = new System.Drawing.Size(424, 115);
            this.textBoxSecondsToTime.TabIndex = 6;
            // 
            // buttonClearTime
            // 
            this.buttonClearTime.Location = new System.Drawing.Point(372, 245);
            this.buttonClearTime.Name = "buttonClearTime";
            this.buttonClearTime.Size = new System.Drawing.Size(75, 23);
            this.buttonClearTime.TabIndex = 7;
            this.buttonClearTime.Text = "清屏";
            this.buttonClearTime.UseVisualStyleBackColor = true;
            this.buttonClearTime.Click += new System.EventHandler(this.buttonClearTime_Click);
            // 
            // dateTimePickerBasic
            // 
            this.dateTimePickerBasic.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerBasic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBasic.Location = new System.Drawing.Point(91, 12);
            this.dateTimePickerBasic.Name = "dateTimePickerBasic";
            this.dateTimePickerBasic.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerBasic.TabIndex = 8;
            this.dateTimePickerBasic.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "基准时间:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerBasic);
            this.Controls.Add(this.buttonClearTime);
            this.Controls.Add(this.textBoxSecondsToTime);
            this.Controls.Add(this.buttonSecondsToTime);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.buttonClearSeconds);
            this.Controls.Add(this.buttonTimeToSeconds);
            this.Controls.Add(this.dateTimePickerCurrent);
            this.Controls.Add(this.textBoxTimeToSeconds);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "时间戳转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTimeToSeconds;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrent;
        private System.Windows.Forms.Button buttonTimeToSeconds;
        private System.Windows.Forms.Button buttonClearSeconds;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.Button buttonSecondsToTime;
        private System.Windows.Forms.TextBox textBoxSecondsToTime;
        private System.Windows.Forms.Button buttonClearTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBasic;
        private System.Windows.Forms.Label label1;
    }
}

