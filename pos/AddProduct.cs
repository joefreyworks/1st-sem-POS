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
    public partial class AddProduct : Form
    {
        public AddProduct()
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
                var result = product.AddProduct(productName, productSize, unit, price); 
                if(result)
                {
                    MessageBox.Show("Record Successfully Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Control ctr in materialCardMain.Controls)
                        if (ctr.GetType() == typeof(MaterialTextBox2))
                            ((MaterialTextBox2)ctr).Clear();
                }
            }
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
