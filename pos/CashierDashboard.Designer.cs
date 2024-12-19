namespace pos
{
    partial class CashierDashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTransactionHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnSettlement = new MaterialSkin.Controls.MaterialButton();
            this.btnProfile = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSales = new MaterialSkin.Controls.MaterialButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pos.Properties.Resources.Revise_furnipos__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.AutoSize = false;
            this.btnTransactionHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTransactionHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTransactionHistory.Depth = 0;
            this.btnTransactionHistory.HighEmphasis = true;
            this.btnTransactionHistory.Icon = null;
            this.btnTransactionHistory.Location = new System.Drawing.Point(6, 241);
            this.btnTransactionHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTransactionHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTransactionHistory.Size = new System.Drawing.Size(175, 36);
            this.btnTransactionHistory.TabIndex = 14;
            this.btnTransactionHistory.Tag = "main";
            this.btnTransactionHistory.Text = "TRANSACTION HISTORY";
            this.btnTransactionHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTransactionHistory.UseAccentColor = false;
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnSettlement
            // 
            this.btnSettlement.AutoSize = false;
            this.btnSettlement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettlement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettlement.Depth = 0;
            this.btnSettlement.HighEmphasis = true;
            this.btnSettlement.Icon = null;
            this.btnSettlement.Location = new System.Drawing.Point(6, 193);
            this.btnSettlement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettlement.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettlement.Name = "btnSettlement";
            this.btnSettlement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettlement.Size = new System.Drawing.Size(175, 36);
            this.btnSettlement.TabIndex = 13;
            this.btnSettlement.Tag = "main";
            this.btnSettlement.Text = "SETTLEMENT";
            this.btnSettlement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSettlement.UseAccentColor = false;
            this.btnSettlement.UseVisualStyleBackColor = true;
            this.btnSettlement.Click += new System.EventHandler(this.btnSettlement_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSize = false;
            this.btnProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProfile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProfile.Depth = 0;
            this.btnProfile.HighEmphasis = true;
            this.btnProfile.Icon = null;
            this.btnProfile.Location = new System.Drawing.Point(4, 145);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProfile.Size = new System.Drawing.Size(179, 36);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.Tag = "main";
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProfile.UseAccentColor = false;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moderustic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "CASHIER DASHBOARD";
            // 
            // btnSales
            // 
            this.btnSales.AutoSize = false;
            this.btnSales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSales.Depth = 0;
            this.btnSales.HighEmphasis = true;
            this.btnSales.Icon = null;
            this.btnSales.Location = new System.Drawing.Point(6, 289);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSales.Name = "btnSales";
            this.btnSales.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSales.Size = new System.Drawing.Size(175, 36);
            this.btnSales.TabIndex = 16;
            this.btnSales.Tag = "main";
            this.btnSales.Text = "SALES";
            this.btnSales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSales.UseAccentColor = false;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(8, 499);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(171, 36);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(190, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(760, 550);
            this.panelMain.TabIndex = 18;
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnSettlement);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierDashboard";
            this.Text = "CashierDashboard";
            this.Load += new System.EventHandler(this.CashierDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnTransactionHistory;
        private MaterialSkin.Controls.MaterialButton btnSettlement;
        private MaterialSkin.Controls.MaterialButton btnProfile;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnSales;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private System.Windows.Forms.Panel panelMain;
    }
}