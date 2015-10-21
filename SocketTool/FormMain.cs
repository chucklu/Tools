using System;
using System.Windows.Forms;

namespace SocketTool
{
    public partial class FormMain : Form
    {
        private FormList formList;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            formList = new FormList
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                MdiParent = this,
                Dock = DockStyle.Left,
                Width = 200
            };
            formList.Show();

            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void 属性栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (属性栏ToolStripMenuItem.Checked)
            {
               formList.Hide();
            }
            else
            {
               formList.Show();
            }
            属性栏ToolStripMenuItem.Checked = !属性栏ToolStripMenuItem.Checked;
        }
    }
}
