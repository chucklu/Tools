using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnixTime
{
    public partial class FormMain : Form
    {

        private DateTime dateTime1970;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTime1970 = new DateTime(1970, 1, 1, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var timeSpan = dateTimePicker.Value - dateTime1970;
            var seconds = timeSpan.Ticks / TimeSpan.TicksPerSecond;
            textBox.AppendText(string.Format("时间:{3}  秒数:{0}  0x{1}{2}",
                seconds, seconds.ToString("X2"), Environment.NewLine,dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}
