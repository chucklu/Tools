using System;
using System.Windows.Forms;
using UnixTime.Properties;

namespace UnixTime
{
    public partial class FormMain : Form
    {

        private DateTime dateTimeBasic = DateTime.MinValue;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerBasic.Value = Settings.Default.UnixTime;
        }

        /// <summary>
        /// 时间转换成相对于基准时间的秒数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimeToSeconds_Click(object sender, EventArgs e)
        {
            AppendBasicTime();
            var timeSpan = dateTimePickerCurrent.Value - dateTimeBasic;
            var seconds = timeSpan.Ticks / TimeSpan.TicksPerSecond;
            textBoxTimeToSeconds.AppendText(string.Format("时间:{3}  秒数:{0}  0x{1}{2}",
                seconds, seconds.ToString("X2"), Environment.NewLine,dateTimePickerCurrent.Value.ToString("yyyy-MM-dd HH:mm:ss")));
        }

        private void buttonClearSeconds_Click(object sender, EventArgs e)
        {
            textBoxTimeToSeconds.Clear();
        }

        /// <summary>
        /// 相对于基准时间的描述转换为时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSecondsToTime_Click(object sender, EventArgs e)
        {
            AppendBasicTime();
            string sec = textBoxSeconds.Text.Trim();
            if (string.IsNullOrEmpty(sec))
            {
                throw new Exception("输入的秒数不允许为空");
            }
            long seconds;
            if (sec.StartsWith("0x") || sec.StartsWith("0X"))
            {
                sec = sec.Replace(" ", string.Empty);
                seconds = Convert.ToInt64(sec, 16);
            }
            else
            {
                seconds = Convert.ToInt64(sec);
            }
            var dateTime = dateTimeBasic.AddSeconds(seconds);
            textBoxSecondsToTime.AppendText(string.Format("秒数:{0}  0x{1}  时间:{2}{3}",
                seconds,seconds.ToString("X2"),dateTime.ToString("yyyy-MM-dd HH:mm:ss"),Environment.NewLine));
        }

        private void buttonClearTime_Click(object sender, EventArgs e)
        {
            textBoxSecondsToTime.Clear();
        }

        private void AppendBasicTime()
        {
            if (dateTimeBasic != dateTimePickerBasic.Value)
            {
                SaveBasicTimeToSetting();
                GetBasicTimeFromSetting();
                string info = string.Format("{0}基准时间:{1}{0}", Environment.NewLine, dateTimePickerBasic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                textBoxTimeToSeconds.AppendText(info);
                textBoxSecondsToTime.AppendText(info);
            }
        }

        private void GetBasicTimeFromSetting()
        {
            dateTimeBasic = Settings.Default.UnixTime;
        }

        private void SaveBasicTimeToSetting()
        {
            Settings.Default.UnixTime = dateTimePickerBasic.Value;
            Settings.Default.Save();
        }
    }
}
