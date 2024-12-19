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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var info = new Account().GetAccount(COMMON.username);
            if (info != null)
            {
                if(info.Rows.Count > 0)
                {
                    lblName.Text = info.Rows[0]["FullName"].ToString();
                    lblEmployeeNumber.Text = info.Rows[0]["Username"].ToString();
                    lblPositions.Text = info.Rows[0]["Positions"].ToString();
                    lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    lblLocation.Text = info.Rows[0]["Address"].ToString();
                }
            }
        }
    }
}
