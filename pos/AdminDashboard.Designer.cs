namespace pos
{
    partial class AdminDashboard
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.btnSales = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductList = new MaterialSkin.Controls.MaterialButton();
            this.btnInventory = new MaterialSkin.Controls.MaterialButton();
            this.btnAccounts = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(190, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(760, 550);
            this.panelMain.TabIndex = 26;
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
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSales
            // 
            this.btnSales.AutoSize = false;
            this.btnSales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSales.Depth = 0;
            this.btnSales.HighEmphasis = true;
            this.btnSales.Icon = null;
            this.btnSales.Location = new System.Drawing.Point(6, 288);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSales.Name = "btnSales";
            this.btnSales.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSales.Size = new System.Drawing.Size(175, 36);
            this.btnSales.TabIndex = 24;
            this.btnSales.Tag = "main";
            this.btnSales.Text = "SALES";
            this.btnSales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSales.UseAccentColor = false;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moderustic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "ADMIN DASHBOARD";
            // 
            // btnProductList
            // 
            this.btnProductList.AutoSize = false;
            this.btnProductList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProductList.Depth = 0;
            this.btnProductList.HighEmphasis = true;
            this.btnProductList.Icon = null;
            this.btnProductList.Location = new System.Drawing.Point(6, 240);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProductList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProductList.Size = new System.Drawing.Size(175, 36);
            this.btnProductList.TabIndex = 22;
            this.btnProductList.Tag = "main";
            this.btnProductList.Text = "PRODUCT LIST";
            this.btnProductList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnProductList.UseAccentColor = false;
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.AutoSize = false;
            this.btnInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInventory.Depth = 0;
            this.btnInventory.HighEmphasis = true;
            this.btnInventory.Icon = null;
            this.btnInventory.Location = new System.Drawing.Point(6, 192);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInventory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInventory.Size = new System.Drawing.Size(175, 36);
            this.btnInventory.TabIndex = 21;
            this.btnInventory.Tag = "main";
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnInventory.UseAccentColor = false;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.AutoSize = false;
            this.btnAccounts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccounts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAccounts.Depth = 0;
            this.btnAccounts.HighEmphasis = true;
            this.btnAccounts.Icon = null;
            this.btnAccounts.Location = new System.Drawing.Point(4, 145);
            this.btnAccounts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAccounts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAccounts.Size = new System.Drawing.Size(179, 36);
            this.btnAccounts.TabIndex = 20;
            this.btnAccounts.Tag = "main";
            this.btnAccounts.Text = "ACCONT";
            this.btnAccounts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAccounts.UseAccentColor = false;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pos.Properties.Resources.Revise_furnipos__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialButton btnSales;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnProductList;
        private MaterialSkin.Controls.MaterialButton btnInventory;
        private MaterialSkin.Controls.MaterialButton btnAccounts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}