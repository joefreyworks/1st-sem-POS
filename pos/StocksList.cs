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
    public partial class StocksList : Form
    {
        public StocksList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var stocks = new AddStocks();
            stocks.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadStocks();
        }

        private void LoadStocks()
        {
            var stocks = new Stocks().GetAllStocks();
            dgvStocks.Rows.Clear();
            foreach (DataRow item in stocks.Rows)
            {
                dgvStocks.Rows.Add(
                    item["ProductID"].ToString(),
                    item["ProductName"].ToString(),
                    item["Supplier"].ToString(),
                    DateTime.Parse(item["DateDelivered"].ToString()).ToShortDateString(),
                    item["QuantityReceived"].ToString(),
                    item["ReOrderLevel"].ToString()
                    );
            }

        }

        private void StocksList_Load(object sender, EventArgs e)
        {
            LoadStocks();
        }
    }
}
