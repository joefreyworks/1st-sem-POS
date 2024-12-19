using MaterialSkin.Controls;
using pos.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
    public partial class CashierDashboard : Form
    {
        public CashierDashboard()
        {
            InitializeComponent();
        }

        public void PanelContainer(Form form)
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

        private void ButtonChange( MaterialButton btn )
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl.GetType() == btn.GetType())
                    if (ctrl.Tag != null)
                        if (ctrl.Tag.ToString() == "main")
                            ((MaterialButton)ctrl).Type = MaterialButton.MaterialButtonType.Outlined;
            btn.Type = MaterialButton.MaterialButtonType.Contained;
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            ButtonChange(btnProfile);
            PanelContainer(new Profile());
        }

        private void btnSettlement_Click(object sender, EventArgs e)
        {
            ButtonChange(btnSettlement);
            PanelContainer(new Settlement());
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            ButtonChange(btnTransactionHistory);
            PanelContainer(new CashierTransactionHistory());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ButtonChange(btnSales);
            PanelContainer(new CustomerSalesList());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
                COMMON.route = new CashierLogin();
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            PanelContainer(new Profile());
        }
    }
}
