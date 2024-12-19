using MaterialSkin.Controls;
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

namespace pos
{
    public partial class RegisterAccount : Form
    {
        public RegisterAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool required = true;
            foreach(Control ctr in materialCardMain.Controls)
            {
                if(ctr.GetType() == typeof(MaterialTextBox2))
                {
                    if(((MaterialTextBox2)ctr).Text.Trim() == string.Empty)
                    {
                        errorProvider1.SetError((MaterialTextBox2)ctr, "Required!");
                        ((MaterialTextBox2)ctr).Focus();
                        required = false;
                    }
                }
            }

            if (required)
            {
                string fullName = txtFullName.Text;
                string positions = txtPositions.Text;
                string email = txtEmail.Text;
                string contact = txtContactNumber.Text;
                string address = txtAddress.Text;
                string username = txtEmployeeNumber.Text;
                string password = txtPassword.Text;
                var account = new Account();
                var result = account.AddAccount(username, password, fullName, email, contact, address, positions);
                if (result)
                { 
                    MessageBox.Show("Record Successfully Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    foreach (Control ctr in materialCardMain.Controls)
                        if (ctr.GetType() == typeof(MaterialTextBox2))
                            ((MaterialTextBox2)ctr).Clear();

                }
            }

        }

        private void RegisterAccount_Load(object sender, EventArgs e)
        {
            txtPositions.SelectedIndex = 0;
        }
    }
}
