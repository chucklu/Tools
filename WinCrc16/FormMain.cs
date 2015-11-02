﻿using System;
using System.Windows.Forms;

namespace WinCrc16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCrc16_Click(object sender, EventArgs e)
        {
            //首先去除输入字符串中的空格
            string input = textBoxInput.Text.Replace(" ", string.Empty);
            string result = ChuckLu.Utility.Crc16.CheckHexSpaceString(input);
            textBoxResult.Text = result;
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }
    }
}
