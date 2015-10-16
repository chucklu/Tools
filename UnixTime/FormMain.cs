using System;
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

        private void buttonTimeToSeconds_Click(object sender, EventArgs e)
        {
            var timeSpan = dateTimePicker.Value - dateTime1970;
            var seconds = timeSpan.Ticks / TimeSpan.TicksPerSecond;
            textBoxTimeToSeconds.AppendText(string.Format("时间:{3}  秒数:{0}  0x{1}{2}",
                seconds, seconds.ToString("X2"), Environment.NewLine,dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTimeToSeconds.Clear();
        }

        private void buttonSecondsToTime_Click(object sender, EventArgs e)
        {
            string sec = textBoxSeconds.Text.Trim();
            long seconds;
            if (sec.StartsWith("0x") || sec.StartsWith("0X"))
            {
                seconds = Convert.ToInt64(sec, 16);
            }
            else
            {
                seconds = Convert.ToInt64(sec);
            }
            var dateTime = dateTime1970.AddSeconds(seconds);
            textBoxSecondsToTime.AppendText(string.Format("秒数:{0}  0x{1}  时间:{2}{3}",
                seconds,seconds.ToString("X2"),dateTime.ToString("yyyy-MM-dd HH:mm:ss"),Environment.NewLine));
        }

        private void buttonClearTime_Click(object sender, EventArgs e)
        {
            textBoxSecondsToTime.Clear();
        }
    }
}
