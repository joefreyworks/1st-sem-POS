namespace pos
{
    partial class AddStocks
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
            this.components = new System.ComponentModel.Container();
            this.materialCardMain = new MaterialSkin.Controls.MaterialCard();
            this.lblProductSize = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDeliverDate = new System.Windows.Forms.DateTimePicker();
            this.txtReOrderLevel = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSupplier = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtQuantityReceived = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCardMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCardMain
            // 
            this.materialCardMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardMain.Controls.Add(this.lblProductSize);
            this.materialCardMain.Controls.Add(this.materialLabel1);
            this.materialCardMain.Controls.Add(this.dtpDeliverDate);
            this.materialCardMain.Controls.Add(this.txtReOrderLevel);
            this.materialCardMain.Controls.Add(this.txtProducts);
            this.materialCardMain.Controls.Add(this.txtSupplier);
            this.materialCardMain.Controls.Add(this.txtQuantityReceived);
            this.materialCardMain.Depth = 0;
            this.materialCardMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardMain.Location = new System.Drawing.Point(12, 23);
            this.materialCardMain.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardMain.Name = "materialCardMain";
            this.materialCardMain.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardMain.Size = new System.Drawing.Size(419, 380);
            this.materialCardMain.TabIndex = 0;
            // 
            // lblProductSize
            // 
            this.lblProductSize.AutoSize = true;
            this.lblProductSize.Depth = 0;
            this.lblProductSize.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductSize.Location = new System.Drawing.Point(37, 69);
            this.lblProductSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductSize.Name = "lblProductSize";
            this.lblProductSize.Size = new System.Drawing.Size(102, 19);
            this.lblProductSize.TabIndex = 28;
            this.lblProductSize.Text = "Product Size: -";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(27, 180);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(103, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Date Delivered";
            // 
            // dtpDeliverDate
            // 
            this.dtpDeliverDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeliverDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliverDate.Location = new System.Drawing.Point(30, 202);
            this.dtpDeliverDate.Name = "dtpDeliverDate";
            this.dtpDeliverDate.Size = new System.Drawing.Size(358, 31);
            this.dtpDeliverDate.TabIndex = 2;
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.AnimateReadOnly = false;
            this.txtReOrderLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtReOrderLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReOrderLevel.Depth = 0;
            this.txtReOrderLevel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReOrderLevel.HideSelection = true;
            this.txtReOrderLevel.Hint = "Re-Order Level";
            this.txtReOrderLevel.LeadingIcon = null;
            this.txtReOrderLevel.Location = new System.Drawing.Point(30, 318);
            this.txtReOrderLevel.MaxLength = 32767;
            this.txtReOrderLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.PasswordChar = '\0';
            this.txtReOrderLevel.PrefixSuffixText = null;
            this.txtReOrderLevel.ReadOnly = false;
            this.txtReOrderLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReOrderLevel.SelectedText = "";
            this.txtReOrderLevel.SelectionLength = 0;
            this.txtReOrderLevel.SelectionStart = 0;
            this.txtReOrderLevel.ShortcutsEnabled = true;
            this.txtReOrderLevel.Size = new System.Drawing.Size(358, 48);
            this.txtReOrderLevel.TabIndex = 4;
            this.txtReOrderLevel.TabStop = false;
            this.txtReOrderLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReOrderLevel.TrailingIcon = null;
            this.txtReOrderLevel.UseAccent = false;
            this.txtReOrderLevel.UseSystemPasswordChar = false;
            this.txtReOrderLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityReceived_KeyPress);
            // 
            // txtProducts
            // 
            this.txtProducts.AutoResize = false;
            this.txtProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtProducts.Depth = 0;
            this.txtProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtProducts.DropDownHeight = 174;
            this.txtProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProducts.DropDownWidth = 121;
            this.txtProducts.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtProducts.FormattingEnabled = true;
            this.txtProducts.Hint = "Products";
            this.txtProducts.IntegralHeight = false;
            this.txtProducts.ItemHeight = 43;
            this.txtProducts.Location = new System.Drawing.Point(30, 17);
            this.txtProducts.MaxDropDownItems = 4;
            this.txtProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(358, 49);
            this.txtProducts.StartIndex = 0;
            this.txtProducts.TabIndex = 0;
            this.txtProducts.UseAccent = false;
            this.txtProducts.SelectedIndexChanged += new System.EventHandler(this.txtProducts_SelectedIndexChanged);
            // 
            // txtSupplier
            // 
            this.txtSupplier.AnimateReadOnly = false;
            this.txtSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSupplier.Depth = 0;
            this.txtSupplier.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSupplier.HideSelection = true;
            this.txtSupplier.Hint = "Supplier";
            this.txtSupplier.LeadingIcon = null;
            this.txtSupplier.Location = new System.Drawing.Point(30, 112);
            this.txtSupplier.MaxLength = 32767;
            this.txtSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.PrefixSuffixText = null;
            this.txtSupplier.ReadOnly = false;
            this.txtSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.SelectionLength = 0;
            this.txtSupplier.SelectionStart = 0;
            this.txtSupplier.ShortcutsEnabled = true;
            this.txtSupplier.Size = new System.Drawing.Size(358, 48);
            this.txtSupplier.TabIndex = 1;
            this.txtSupplier.TabStop = false;
            this.txtSupplier.Text = "Tyler, The Creator";
            this.txtSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSupplier.TrailingIcon = null;
            this.txtSupplier.UseAccent = false;
            this.txtSupplier.UseSystemPasswordChar = false;
            // 
            // txtQuantityReceived
            // 
            this.txtQuantityReceived.AnimateReadOnly = false;
            this.txtQuantityReceived.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantityReceived.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantityReceived.Depth = 0;
            this.txtQuantityReceived.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantityReceived.HideSelection = true;
            this.txtQuantityReceived.Hint = "Quantity Received";
            this.txtQuantityReceived.LeadingIcon = null;
            this.txtQuantityReceived.Location = new System.Drawing.Point(30, 253);
            this.txtQuantityReceived.MaxLength = 32767;
            this.txtQuantityReceived.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantityReceived.Name = "txtQuantityReceived";
            this.txtQuantityReceived.PasswordChar = '\0';
            this.txtQuantityReceived.PrefixSuffixText = null;
            this.txtQuantityReceived.ReadOnly = false;
            this.txtQuantityReceived.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantityReceived.SelectedText = "";
            this.txtQuantityReceived.SelectionLength = 0;
            this.txtQuantityReceived.SelectionStart = 0;
            this.txtQuantityReceived.ShortcutsEnabled = true;
            this.txtQuantityReceived.Size = new System.Drawing.Size(358, 48);
            this.txtQuantityReceived.TabIndex = 3;
            this.txtQuantityReceived.TabStop = false;
            this.txtQuantityReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantityReceived.TrailingIcon = null;
            this.txtQuantityReceived.UseAccent = false;
            this.txtQuantityReceived.UseSystemPasswordChar = false;
            this.txtQuantityReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityReceived_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(316, 423);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(115, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(189, 423);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(119, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(453, 479);
            this.Controls.Add(this.materialCardMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "AddStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stocks";
            this.Load += new System.EventHandler(this.AddStocks_Load);
            this.materialCardMain.ResumeLayout(false);
            this.materialCardMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCardMain;
        private MaterialSkin.Controls.MaterialTextBox2 txtReOrderLevel;
        private MaterialSkin.Controls.MaterialComboBox txtProducts;
        private MaterialSkin.Controls.MaterialTextBox2 txtSupplier;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantityReceived;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpDeliverDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel lblProductSize;
    }
}