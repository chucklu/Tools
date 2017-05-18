using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class FormMain : Form
    {
        private List<IOrder> forms;

        public FormMain()
        {
            InitializeComponent();
            Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            forms = new List<IOrder>();

            var assembly = Assembly.GetExecutingAssembly();
            var modules = assembly.GetModules();
            foreach (var module in modules)
            {
                var types = module.GetTypes();
                var formTypes =
                    types.Where(x => typeof(IOrder).IsAssignableFrom(x) && typeof(Form).IsAssignableFrom(x));
                foreach (var type in formTypes)
                {
                    var form = Activator.CreateInstance(type) as Form;
                    if (form != null)
                    {
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        var order = form as IOrder;
                        forms.Add(order);
                    }
                }
            }

            forms = forms.OrderBy(x => x.Order).ToList();

            foreach (var order in forms)
            {
                var form = order as Form;
                if (form != null)
                {
                    TabPage tabPage = new TabPage {Text = form.Text};
                    tabPage.Controls.Add(form);
                    form.Show();
                    tabControlMain.TabPages.Add(tabPage);
                }
            }
        }
    }
}