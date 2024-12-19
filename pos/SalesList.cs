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
    public partial class SalesList : Form
    {
        public SalesList()
        {
            InitializeComponent();
        }

        private void SalesList_Load(object sender, EventArgs e)
        {
            cmb.SelectedIndex = 0;

            // Populate years (2022 to current year)
            cmbYear.Items.Clear();
            for (int year = 2022; year <= DateTime.Now.Year; year++)
            {
                cmbYear.Items.Add(year.ToString());
            }

            // Select current year by default
            cmbYear.SelectedItem = DateTime.Now.Year.ToString();

            // Populate months (January to December)
            cmbMonth.Items.Clear();
            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month));
            }

            // Select current month by default
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.SelectedIndex == 0)
            {
                cmbYear.Visible = false;
                cmbMonth.Visible = false;
                dtpDaily.Visible = true;
                DailySales();
            }
            else if (cmb.SelectedIndex == 1)
            {
                cmbYear.Visible = true;
                cmbMonth.Visible = true;
                dtpDaily.Visible = false;
                MonthlySales();
            }
            else
            {
                cmbYear.Visible = true;
                cmbMonth.Visible = false;
                dtpDaily.Visible = false;
                YearlySales();
            }
        }

        private void dtpDaily_ValueChanged(object sender, EventArgs e)
        {
            DailySales();
        }

        private void DailySales()
        {
            var sales = new Sales().GetDailySales(dtpDaily.Value);
            dgvRecords.DataSource = sales;
            double totalBalance = 0;
            foreach (DataRow row in sales.Rows)
            {
                totalBalance += double.Parse(row["Sales"].ToString());
            }
            lblTotal.Text = string.Format("TOTAL SALES: {0}", totalBalance.ToString("N2"));
        }

        private void MonthlySales()
        {
            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.Text);
            var sales = new Sales().GetMonthlySales(year, month);
            dgvRecords.DataSource = sales;
            double totalBalance = 0;
            foreach (DataRow row in sales.Rows)
            {
                totalBalance += double.Parse(row["Sales"].ToString());
            }
            lblTotal.Text = string.Format("TOTAL SALES: {0}", totalBalance.ToString("N2"));
        }

        private void YearlySales()
        {
            int year = int.Parse(cmbYear.Text);
            var sales = new Sales().GetYearlySales(year);
            dgvRecords.DataSource = sales;
            double totalBalance = 0;
            foreach (DataRow row in sales.Rows)
            {
                totalBalance += double.Parse(row["Total Sales"].ToString());
            }
            lblTotal.Text = string.Format("TOTAL SALES: {0}", totalBalance.ToString("N2"));
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.SelectedIndex == 1)
                MonthlySales();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.SelectedIndex == 1)
                MonthlySales();
            else if (cmb.SelectedIndex == 2)
                YearlySales();
        }
    }
}
