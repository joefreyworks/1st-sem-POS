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
    public partial class InventoryList : Form
    {
        public InventoryList()
        {
            InitializeComponent();
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            LoadStocks();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadStocks();
        }
        private void LoadStocks()
        {
            var inventory = new Inventory().GetAllInventory();
            dgvStocks.Rows.Clear();
            foreach (DataRow item in inventory.Rows)
            {
                dgvStocks.Rows.Add(
                    item["ProductID"].ToString(),
                    item["ProductName"].ToString(),
                    item["Supplier"].ToString(),
                    DateTime.Parse(item["DateDelivered"].ToString()).ToShortDateString(),
                    item["QuantityReceived"].ToString(),
                    item["UpdatedBy"].ToString(),
                    item["ReOrderLevel"].ToString(),
                    item["QuantityRemaining"].ToString()
                    );
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddStocks();
            frm.ShowDialog();
        }
    }
}
