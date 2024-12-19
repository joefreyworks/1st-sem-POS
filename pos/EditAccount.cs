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
    public partial class EditAccount : Form
    {
        private int ID;
        public EditAccount(int iD)
        {
            InitializeComponent();
            ID = iD;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to update this account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.No)
                return;

            bool required = true;
            foreach (Control ctr in materialCardMain.Controls)
            {
                if (ctr.GetType() == typeof(MaterialTextBox2))
                {
                    if (((MaterialTextBox2)ctr).Text.Trim() == string.Empty)
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
                var result = account.UpdateAccount(username, password, fullName, email, contact, address, positions, ID);
                if (result)
                {
                    MessageBox.Show("Record Successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            DataRow dr = new Account().GetAccountByID(ID).Rows[0];
            txtFullName.Text = dr["fullName"].ToString();
            txtPositions.Text = dr["Positions"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtContactNumber.Text = dr["ContactNumber"].ToString();
            txtAddress.Text = dr["Address"].ToString();
            txtEmployeeNumber.Text = dr["Username"].ToString();
            txtPassword.Text = dr["Password"].ToString();
        }
    }
}
