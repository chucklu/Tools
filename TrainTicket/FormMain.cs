using System;
using System.Windows.Forms;

namespace TrainTicket
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 可以提前60天购票
        /// </summary>
        private const int AheadDays = 60;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadBuyTicketTime();
        }

        private void LoadBuyTicketTime()
        {
            DateTime dateTime = DateTime.Now;
            //因为当天买票坐火车，也算是提前一天买票了，所这里加上提前的天数-1
            var buyTicketTime = dateTime.AddDays(AheadDays - 1);
            textBox1.AppendText(string.Format("今天是{0},{2}可以买到{1}的火车票",
                dateTime.ToString("yyyy年MM月dd日"), buyTicketTime.ToString("yyyy年MM月dd日"), Environment.NewLine));
        }
    }
}
