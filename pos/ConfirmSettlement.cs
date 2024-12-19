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
    public partial class ConfirmSettlement : Form
    {
        DataGridView _dgv;
        public ConfirmSettlement(DataGridView dgv)
        {
            InitializeComponent();
            _dgv = dgv;
        }

        private void ConfirmSettlement_Load(object sender, EventArgs e)
        {
            dgvSettlement = _dgv;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }
    }
}
