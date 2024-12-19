using pos.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos.common;

namespace pos
{
    public partial class CashierLogin : Form
    {
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var acct = new Account();
            var result = acct.GetAccount(username, password, "cashier");
            if (result.Rows.Count == 0)
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                COMMON.route = new CashierDashboard();
                COMMON.username = username;
                COMMON.userId = int.Parse(result.Rows[0]["ID"].ToString());
            }
                
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            COMMON.route = new LoginForm();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            COMMON.route = new FindAccount();
        }

        private void CashierLogin_Load(object sender, EventArgs e)
        {
            string currentUser = Environment.UserName;
            if (currentUser != "bOzmh")
                txtUsername.Text = txtPassword.Text = "";
        }
    }
}
