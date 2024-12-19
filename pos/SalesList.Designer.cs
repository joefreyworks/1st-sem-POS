namespace pos
{
    partial class SalesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb = new MetroFramework.Controls.MetroComboBox();
            this.cmbMonth = new MetroFramework.Controls.MetroComboBox();
            this.dtpDaily = new System.Windows.Forms.DateTimePicker();
            this.cmbYear = new MetroFramework.Controls.MetroComboBox();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.cmbYear);
            this.panel1.Controls.Add(this.dtpDaily);
            this.panel1.Controls.Add(this.cmbMonth);
            this.panel1.Controls.Add(this.cmb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 52);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moderustic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sales Report";
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.ItemHeight = 23;
            this.cmb.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Yearly"});
            this.cmb.Location = new System.Drawing.Point(580, 14);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(168, 29);
            this.cmb.TabIndex = 10;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.ItemHeight = 23;
            this.cmbMonth.Location = new System.Drawing.Point(251, 14);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(179, 29);
            this.cmbMonth.TabIndex = 11;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // dtpDaily
            // 
            this.dtpDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDaily.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDaily.Location = new System.Drawing.Point(395, 14);
            this.dtpDaily.Name = "dtpDaily";
            this.dtpDaily.Size = new System.Drawing.Size(179, 29);
            this.dtpDaily.TabIndex = 12;
            this.dtpDaily.ValueChanged += new System.EventHandler(this.dtpDaily_ValueChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 23;
            this.cmbYear.Location = new System.Drawing.Point(445, 14);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(129, 29);
            this.cmbYear.TabIndex = 13;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AllowUserToResizeRows = false;
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(12, 67);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersVisible = false;
            this.dgvRecords.Size = new System.Drawing.Size(736, 424);
            this.dgvRecords.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Moderustic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(12, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(186, 36);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL SALES: -";
            // 
            // SalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(760, 550);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesList";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbMonth;
        private MetroFramework.Controls.MetroComboBox cmb;
        private System.Windows.Forms.DateTimePicker dtpDaily;
        private MetroFramework.Controls.MetroComboBox cmbYear;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Label lblTotal;
    }
}