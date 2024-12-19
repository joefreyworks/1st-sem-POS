using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos.common;

namespace pos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PanelControl(new CashierLogin());
            routeTimer.Start();
        }

        public void PanelControl(Form form)
        {
            form.TopLevel = false;
            form.Left = 0;
            form.Top = 0;
            if (panelMain.Controls.Count == 0)
            {
                panelMain.Controls.Add(form);
                form.Show();
                COMMON.route = null;
            }
            else
            {
                foreach (Control c in panelMain.Controls)
                {
                    if (c != form)
                    {
                        panelMain.Controls.Clear();
                        panelMain.Controls.Add(form);
                        form.Show();
                        COMMON.route = null;
                    }
                }
            }
        }

        private void routeTimer_Tick(object sender, EventArgs e)
        {
            if (COMMON.route != null)
                PanelControl(COMMON.route);
        }
    }
}
