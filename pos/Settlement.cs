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
    public partial class Settlement : Form
    {
        private static Random random = new Random();
        int transactionNumber;
        DataTable product;

        public Settlement()
        {
            InitializeComponent();
            product = new Inventory().GetAllInventory();
        }
        public static int GenerateTransactionNumber()
        {
            // Generate a random number between 100000 and 999999 (6 digits)
            return random.Next(100000, 1000000);
        }
        private void Settlement_Load(object sender, EventArgs e)
        {
            LoadProduct();
            this.Width = 760;
            this.Height = 550;
            materialCard3.Visible = false;
            materialCard4.Visible = false;

            materialCard4.Location = new Point(materialCard4.Location.X, materialCard1.Location.Y);
            materialCard3.Location = new Point(materialCard3.Location.X, materialCard2.Location.Y);
            transactionNumber = GenerateTransactionNumber();
            Console.WriteLine("Generated Transaction Number: " + transactionNumber);
        }

        private void LoadProduct()
        {
           
            // Remove duplicates based on ProductName
            DataTable distinctProducts = product.AsEnumerable()
                .GroupBy(row => row.Field<string>("ProductName")) // Group by ProductName
                .Select(group => group.First())                  // Select the first row in each group
                .CopyToDataTable();                              // Convert back to a DataTable

            txtProducts.DisplayMember = "ProductName";
            txtProducts.ValueMember = "ID";
            txtProducts.DataSource = distinctProducts;
        }
        private void txtProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure a product is selected
            if (txtProducts.SelectedValue != null)
            {
                // Fetch product sizes for the selected product
                var productSizes = new Inventory().GetProductSizesByProductName(txtProducts.Text);

                
                txtProductSize.DisplayMember = "ProductSize"; // Property to display
                txtProductSize.ValueMember = "ProductID";    // Property for value (optional)
                // Bind product sizes to txtProductSize
                txtProductSize.DataSource = productSizes;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtQty.Text = (int.Parse(txtQty.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQty.Text) > 0)
                txtQty.Text = (int.Parse(txtQty.Text) - 1).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProducts.SelectedIndex = 0;
            txtQty.Text = "1";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Ensure there is a selected item
            if (txtProductSize.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)txtProductSize.SelectedItem;
                string productName = selectedRow["ProductName"].ToString() + " - " + selectedRow["ProductSize"];
                int productID = Convert.ToInt32(selectedRow["ProductID"]);
                string price = (int.Parse(txtQty.Text) * int.Parse(selectedRow["Price"].ToString())).ToString();
                string qty = txtQty.Text;
                dgvSettlement.Rows.Add(productID, productName, qty, price);
                dgvSettlement2.Rows.Add(productID, productName, qty, price);
                Compute();
            }
        }

        void Compute()
        {
            int total = 0;
            double vatRate = 0.12; // 12% VAT rate
            double vatableTotal = 0;
            double TotalVat = 0; // Variable to store the total VAT

            for (int i = 0; i < dgvSettlement.Rows.Count; i++)
            {
                if (dgvSettlement.Rows[i].Cells[3].Value != null)
                {
                    int price = int.Parse(dgvSettlement.Rows[i].Cells[3].Value.ToString());
                    total += price;

                    // Calculate VAT
                    double vat = price * vatRate;
                    TotalVat += vat;

                    // Calculate VATable amount for this row
                    double vatableAmount = price - vat;
                    vatableTotal += vatableAmount;
                }
            }

            lblTotal.Text = total.ToString();
            lblVatableTotal.Text = vatableTotal.ToString(); // Display the total VATable amount
            lblTotalVat.Text = TotalVat.ToString(); // Display the total VAT
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dgvSettlement.RowCount == 0)
            {
                MessageBox.Show("No Record Found to Save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var msg = MessageBox.Show("Would you like to proceed with order settlement?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    materialCard1.Visible = false;
                    materialCard2.Visible = false;
                    materialCard3.Visible = true;
                    materialCard4.Visible = true;
                }
            }
                
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            if(txtAmountPaid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Invalid Value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmountPaid.Focus();
                return;
            }

            double amountPaid = double.Parse(txtAmountPaid.Text);
            double total = double.Parse(lblTotal.Text);
            double change = amountPaid - total;
            if(change < 0)
            {
                MessageBox.Show("Invalid Value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmountPaid.Focus();
                return;
            }


            int productId = 0;
            int OrderQuantity = 0;
            int price = 0;
            string soldTo = "";
            


            DateTime dateOrder = DateTime.Now;
            
            var sales = new Sales();
            for (int i = 0; i < dgvSettlement2.RowCount; i++)
            {
                productId = int.Parse(dgvSettlement2.Rows[i].Cells[0].Value.ToString());
                OrderQuantity = int.Parse(dgvSettlement2.Rows[i].Cells[2].Value.ToString());
                price = int.Parse(dgvSettlement2.Rows[i].Cells[3].Value.ToString());

                sales.AddSale(productId, OrderQuantity, price, dateOrder, soldTo, COMMON.userId, transactionNumber.ToString());
            }
      
            MessageBox.Show("Record Successfully Save!!");
           
            // Create a new DataTable
            DataTable dt = new DataTable();

            // Add columns
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));

            foreach (DataGridViewRow row in dgvSettlement.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                // Create a new DataRow for the DataTable
                DataRow dr = dt.NewRow();
                dr["ID"] = row.Cells[0].Value;
                dr["Name"] = row.Cells[1].Value;
                dr["Price"] = row.Cells[2].Value;
                dr["Quantity"] = row.Cells[3].Value;

                // Add the DataRow to the DataTable
                dt.Rows.Add(dr);
            }

            var frm = new Receipt(dt, lblTotal.ToString(), change.ToString(), transactionNumber.ToString());
            frm.ShowDialog();

            materialCard1.Visible = true;
            materialCard2.Visible = true;
            materialCard3.Visible = false;
            materialCard4.Visible = false;
            dgvSettlement.Rows.Clear();
            dgvSettlement2.Rows.Clear();
            //Generate new Transaction ID
            transactionNumber = GenerateTransactionNumber();
            Console.WriteLine("Generated Transaction Number: " + transactionNumber);

        }

        public string[] DataGridViewToArray(DataGridView dgv)
        {
            List<string> dataList = new List<string>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] rowValues = new string[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            rowValues[i] = row.Cells[i].Value.ToString();
                        }
                        else
                        {
                            rowValues[i] = string.Empty;
                        }
                    }
                    dataList.AddRange(rowValues);
                }
            }

            return dataList.ToArray();
        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtProductSize.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)txtProductSize.SelectedItem;
                // Extract values from the row
                string productName = selectedRow["ProductName"].ToString();
                int productID = Convert.ToInt32(selectedRow["ProductID"]);
                string productSize = selectedRow["ProductSize"].ToString();
                string price = selectedRow["Price"].ToString();
                string qtyRemaining = selectedRow["QuantityRemaining"].ToString();

                //lblProductSize.Text = string.Format("Size: {0}", productSize);
                lblPrice.Text = string.Format("Price: {0}", price);
                lblMaterials.Text = string.Format("Material : {0}", productName.Contains("Steel") ? "Steel" : "Wood");
                lblColor.BackColor = productName.Contains("Steel") ? Color.FromArgb(219, 224, 229) : Color.FromArgb(178, 147, 91);
                lblStocks.Text = string.Format("Stocks: {0}", qtyRemaining);
            }
        }
    }
}
