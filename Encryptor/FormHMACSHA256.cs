using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class FormHMACSHA256 : Form
    {
        public FormHMACSHA256()
        {
            InitializeComponent();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            string toEncrypt = textBoxInput.Text;
            string secretKey = textBoxSecretKey.Text;

            byte[] key = Encoding.ASCII.GetBytes(secretKey);
            byte[] content = Encoding.ASCII.GetBytes(toEncrypt);

            HMACSHA256 encryptor = new HMACSHA256(key);
            var result = encryptor.ComputeHash(content);

            string hex = string.Join(string.Empty, result.Select(x => x.ToString("x2")));
            string show = $"【{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}】{Environment.NewLine}Input:{toEncrypt}{Environment.NewLine}Security Key:{secretKey}{Environment.NewLine}Result: {hex}{Environment.NewLine}{Environment.NewLine}";
            textBoxResult.AppendText(show);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
        }
    }
}
