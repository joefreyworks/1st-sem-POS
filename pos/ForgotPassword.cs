using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos.classes;
using pos.common;

namespace pos
{
    public partial class ForgotPassword : Form
    {
        string _email;
        public ForgotPassword(string email)
        {
            InitializeComponent();
            this._email = email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            COMMON.route = new CashierLogin();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string password = txtCreateNewPassword.Text;
            string newPass = txtReEnterPassword.Text;
            if (password != newPass)
                MessageBox.Show("Error Password not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                new Account().UpdatePassword(_email, newPass);
                MessageBox.Show("Password Successfully Reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                COMMON.route = new CashierLogin();
            }
                
        }
    }
}
