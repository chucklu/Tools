using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class FormMain : Form
    {
        private List<Form> forms;

        public FormMain()
        {
            InitializeComponent();
            Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            forms = new List<Form>();

            var assembly = Assembly.GetExecutingAssembly();
            var modules = assembly.GetModules();
            foreach (var module in modules)
            {
                var types = module.GetTypes();
                var formTypes = types.Where(x => typeof(Form).IsAssignableFrom(x));
                foreach (var type in formTypes)
                {
                    if (type == typeof(FormMain))
                    {
                        continue;
                    }
                    var form = Activator.CreateInstance(type) as Form;
                    if (form != null)
                    {
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        forms.Add(form);
                    }
                }
            }

            foreach (var form in forms)
            {
                TabPage tabPage = new TabPage {Text = form.Text};
                tabPage.Controls.Add(form);
                form.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
        }
    }
}
