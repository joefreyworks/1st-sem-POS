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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void LoadRecords()
        {
            var result = new DataTable();
            var product = new Products();
            result = product.GetAllProduct();
            dgvProducts.Rows.Clear();
            foreach (DataRow item in result.Rows) 
            {
                dgvProducts.Rows.Add(
                    item["ID"].ToString(),
                    item["ProductName"].ToString(),
                    item["ProductSize"].ToString(),
                    item["Unit"].ToString(),
                    item["Price"].ToString()
                    );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new AddProduct();
            product.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (e.ColumnIndex == 5)
                {
                    var frm = new EditProduct(int.Parse(ID));
                    frm.ShowDialog();
                }
                else if (e.ColumnIndex == 6)
                {
                    var msg = MessageBox.Show("You are about to delete record! Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        var product = new Products();
                        if (product.DeleteProduct(int.Parse(ID)))
                        {
                            LoadRecords();
                            MessageBox.Show("Record Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
