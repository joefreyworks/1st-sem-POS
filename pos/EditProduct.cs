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
    public partial class EditProduct : Form
    {
        int ID;
        public EditProduct(int iD)
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
                string productName = txtProduct.Text;
                string productSize = txtSize.Text;
                string unit = txtUnit.Text;
                double price = double.Parse(txtPrice.Text);
                var product = new Products();
                var result = product.EditProduct(ID, productName, productSize, unit, price);
                if (result)
                {
                    MessageBox.Show("Record Successfully Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            var product = new Products();
            var record = product.GetProduct(ID);
            if (record != null)
            {
                txtProduct.Text = record.Rows[0]["ProductName"].ToString();
                txtPrice.Text = record.Rows[0]["Price"].ToString();
                txtSize.Text = record.Rows[0]["ProductSize"].ToString();
                txtUnit.Text = record.Rows[0]["Unit"].ToString();
            }
        }
    }
}
