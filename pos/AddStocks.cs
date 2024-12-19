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
    public partial class AddStocks : Form
    {
        public AddStocks()
        {
            InitializeComponent();
        }

        private void AddStocks_Load(object sender, EventArgs e)
        {
            var product = new Products().GetAllProduct();
            txtProducts.DisplayMember = "ProductName";
            txtProducts.ValueMember = "ID";
            txtProducts.DataSource = product;
        }

        private void txtQuantityReceived_KeyPress(object sender, KeyPressEventArgs e)
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
                int productID = int.Parse(txtProducts.SelectedValue.ToString());
                string supplier = txtSupplier.Text;
                DateTime dateDelivered = dtpDeliverDate.Value;
                int quantityReceived = int.Parse(txtQuantityReceived.Text);
                int reOrderPrice = int.Parse(txtReOrderLevel.Text);
                var product = new Stocks();
                var inventory = new Inventory();

                var result = product.AddStocks(productID, supplier, dateDelivered, quantityReceived, reOrderPrice);
                if(!inventory.CheckInventoryByProductID(productID))
                {
                    inventory.AddInventory(productID, supplier, dateDelivered, quantityReceived, reOrderPrice, "Manager", quantityReceived);
                }
                else
                {
                    inventory.UpdateInventory(productID, supplier, dateDelivered, quantityReceived, reOrderPrice, "Manager");
                }

                if (result)
                {
                    MessageBox.Show("Record Successfully Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Control ctr in materialCardMain.Controls)
                        if (ctr.GetType() == typeof(MaterialTextBox2))
                            ((MaterialTextBox2)ctr).Clear();
                }
            }
        }

        private void txtProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure there is a selected item
            if (txtProducts.SelectedItem != null)
            {
                // Retrieve the currently selected row as a DataRowView
                DataRowView selectedRow = (DataRowView)txtProducts.SelectedItem;

                // Extract values from the row
                string productName = selectedRow["ProductName"].ToString();
                int productID = Convert.ToInt32(selectedRow["ID"]);
                string productSize = selectedRow["ProductSize"].ToString(); // Get the Size column

                lblProductSize.Text = string.Format("Product Size: {0}", productSize);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
