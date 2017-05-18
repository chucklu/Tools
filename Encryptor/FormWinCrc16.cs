using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ChuckLu.Utility;

namespace Encryptor
{
    public partial class FormWinCrc16 : Form, IOrder
    {
        public FormWinCrc16()
        {
            InitializeComponent();
        }

        private void buttonCrc16_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            //Check the input first
            string pattern = @"^[0-9a-fA-F]$";
            Regex regex = new Regex(pattern);
            var match = regex.IsMatch(input);
            if (!match)
            {
                ChuckMessageBox.ShowInfo("Please input the correct format of Hex");
                return;
            }

            //首先去除输入字符串中的空格
            input = input.Replace(" ", string.Empty);
            string result = Crc16.CheckHexSpaceString(input);
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

        public int Order { get; } = 1;
    }
}
