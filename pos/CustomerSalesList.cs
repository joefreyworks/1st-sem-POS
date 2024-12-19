using pos.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
    public partial class CustomerSalesList : Form
    {
        public CustomerSalesList()
        {
            InitializeComponent();
        }

        private void CustomerSalesList_Load(object sender, EventArgs e)
        {
            lblDate.Text = string.Format("DATE: {0}", DateTime.Now.ToString("MM/dd/yyyy"));
            var sales = new Sales().GetCustomerDailySales(DateTime.Now);
            dgvRecords.DataSource = sales;
            double totalBalance = 0;
            foreach (DataRow row in sales.Rows)
            {
                totalBalance += double.Parse(row["Total Sales"].ToString());
            }
            lblTotal.Text = string.Format("TOTAL SALES: {0}", totalBalance.ToString("N2"));
        }
    }
}
