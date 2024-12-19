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
    public partial class Receipt : Form
    {
        DataTable _dgv;
        string amount;
        string change;
        string transactionNumber;

        public Receipt(DataTable dgv, string amount, string change, string transactionNumber)
        {
            _dgv = dgv;
            this.amount = amount;
            this.change = change;
            this.transactionNumber = transactionNumber;

            InitializeComponent();

        }
      

        private void Receipt_Load(object sender, EventArgs e)
        {
            lblAmount.Text = amount;
            lblChange.Text = change;
            dgvSettlement.DataSource = _dgv;
            dgvSettlement.Columns[0].Visible = false;
            lblTransactionNumber.Text = transactionNumber;
        }
    }
}
