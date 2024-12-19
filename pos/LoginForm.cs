using pos.classes;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            COMMON.route = new CashierLogin();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            COMMON.route = new FindAccount();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var acct = new Account();
            var result = acct.GetAccount(username, password, "administrator");
            if (result.Rows.Count == 0)
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                COMMON.route = new AdminDashboard();
                COMMON.username = username;
                COMMON.userId = int.Parse(result.Rows[0]["ID"].ToString());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string currentUser = Environment.UserName;
            if(currentUser != "bOzmh")
                txtUsername.Text = txtPassword.Text = "";

        }
    }
}
