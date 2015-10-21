using System.Windows.Forms;

namespace SocketTool
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
