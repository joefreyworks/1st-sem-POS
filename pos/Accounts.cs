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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Register a new account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                var frm = new RegisterAccount();
                frm.ShowDialog();
            }
        }

        private void LoadRecords()
        {
            var records = new Account().GetAllAccounts();
            dgvAccounts.Rows.Clear();
            foreach (DataRow item in records.Rows)
            {
                dgvAccounts.Rows.Add(
                    item["ID"].ToString(),
                    item["Username"].ToString(),
                    item["FullName"].ToString(),
                    item["Positions"].ToString(),
                    item["Email"].ToString(),
                    item["ContactNumber"].ToString(),
                    item["Address"].ToString(),
                    DateTime.Parse(item["RegisterDate"].ToString()).ToString("MM/dd/yyyy")
                    );
            }
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string ID = dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (e.ColumnIndex == 8)
                {
                    var frm = new EditAccount(int.Parse(ID));
                    frm.ShowDialog();
                }
                else if (e.ColumnIndex == 9)
                {
                    var msg = MessageBox.Show("You are about to delete record! Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        var account = new Account();
                        if(account.DeleteAccount(int.Parse(ID)))
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
