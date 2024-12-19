namespace pos
{
    partial class AddProduct
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
            this.txtPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUnit = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSize = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProduct = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.materialCardMain.Controls.Add(this.txtPrice);
            this.materialCardMain.Controls.Add(this.txtUnit);
            this.materialCardMain.Controls.Add(this.txtSize);
            this.materialCardMain.Controls.Add(this.txtProduct);
            this.materialCardMain.Depth = 0;
            this.materialCardMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardMain.Location = new System.Drawing.Point(26, 22);
            this.materialCardMain.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardMain.Name = "materialCardMain";
            this.materialCardMain.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardMain.Size = new System.Drawing.Size(419, 331);
            this.materialCardMain.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.HideSelection = true;
            this.txtPrice.Hint = "Price";
            this.txtPrice.LeadingIcon = null;
            this.txtPrice.Location = new System.Drawing.Point(30, 215);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PrefixSuffixText = null;
            this.txtPrice.ReadOnly = false;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(358, 48);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.TabStop = false;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.TrailingIcon = null;
            this.txtPrice.UseAccent = false;
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtUnit
            // 
            this.txtUnit.AutoResize = false;
            this.txtUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUnit.Depth = 0;
            this.txtUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtUnit.DropDownHeight = 174;
            this.txtUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnit.DropDownWidth = 121;
            this.txtUnit.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUnit.FormattingEnabled = true;
            this.txtUnit.Hint = "Unit";
            this.txtUnit.IntegralHeight = false;
            this.txtUnit.ItemHeight = 43;
            this.txtUnit.Items.AddRange(new object[] {
            "PC",
            "BOX"});
            this.txtUnit.Location = new System.Drawing.Point(30, 151);
            this.txtUnit.MaxDropDownItems = 4;
            this.txtUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(358, 49);
            this.txtUnit.StartIndex = 0;
            this.txtUnit.TabIndex = 24;
            this.txtUnit.UseAccent = false;
            // 
            // txtSize
            // 
            this.txtSize.AnimateReadOnly = false;
            this.txtSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSize.Depth = 0;
            this.txtSize.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSize.HideSelection = true;
            this.txtSize.Hint = "Size";
            this.txtSize.LeadingIcon = null;
            this.txtSize.Location = new System.Drawing.Point(30, 83);
            this.txtSize.MaxLength = 32767;
            this.txtSize.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.PrefixSuffixText = null;
            this.txtSize.ReadOnly = false;
            this.txtSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSize.SelectedText = "";
            this.txtSize.SelectionLength = 0;
            this.txtSize.SelectionStart = 0;
            this.txtSize.ShortcutsEnabled = true;
            this.txtSize.Size = new System.Drawing.Size(358, 48);
            this.txtSize.TabIndex = 23;
            this.txtSize.TabStop = false;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSize.TrailingIcon = null;
            this.txtSize.UseAccent = false;
            this.txtSize.UseSystemPasswordChar = false;
            // 
            // txtProduct
            // 
            this.txtProduct.AnimateReadOnly = false;
            this.txtProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProduct.Depth = 0;
            this.txtProduct.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProduct.HideSelection = true;
            this.txtProduct.Hint = "Product Name";
            this.txtProduct.LeadingIcon = null;
            this.txtProduct.Location = new System.Drawing.Point(30, 17);
            this.txtProduct.MaxLength = 32767;
            this.txtProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.PasswordChar = '\0';
            this.txtProduct.PrefixSuffixText = null;
            this.txtProduct.ReadOnly = false;
            this.txtProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProduct.SelectedText = "";
            this.txtProduct.SelectionLength = 0;
            this.txtProduct.SelectionStart = 0;
            this.txtProduct.ShortcutsEnabled = true;
            this.txtProduct.Size = new System.Drawing.Size(358, 48);
            this.txtProduct.TabIndex = 22;
            this.txtProduct.TabStop = false;
            this.txtProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProduct.TrailingIcon = null;
            this.txtProduct.UseAccent = false;
            this.txtProduct.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(330, 373);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(115, 36);
            this.btnCancel.TabIndex = 25;
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
            this.btnSave.Location = new System.Drawing.Point(203, 373);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(119, 36);
            this.btnSave.TabIndex = 24;
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
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(470, 437);
            this.Controls.Add(this.materialCardMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.materialCardMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCardMain;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrice;
        private MaterialSkin.Controls.MaterialComboBox txtUnit;
        private MaterialSkin.Controls.MaterialTextBox2 txtSize;
        private MaterialSkin.Controls.MaterialTextBox2 txtProduct;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}