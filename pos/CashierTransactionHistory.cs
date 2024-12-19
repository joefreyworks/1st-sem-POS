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
    public partial class CashierTransactionHistory : Form
    {
        public CashierTransactionHistory()
        {
            InitializeComponent();
        }

        private void CashierTransactionHistory_Load(object sender, EventArgs e)
        {
            lblDate.Text = string.Format("DATE: {0}", DateTime.Now.ToString("MM/dd/yyyy"));
            var records = new Sales().GetSales(DateTime.Now);
            dgvRecords.DataSource = records;
        }
    }
}
