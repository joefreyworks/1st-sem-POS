namespace pos
{
    partial class EditAccount
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
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtFullName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCardMain = new MaterialSkin.Controls.MaterialCard();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmployeeNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtAddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContactNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPositions = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCardMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(322, 492);
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
            this.btnSave.Location = new System.Drawing.Point(195, 492);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(119, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "UPDATE";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.AnimateReadOnly = false;
            this.txtFullName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.HideSelection = true;
            this.txtFullName.Hint = "Full Name";
            this.txtFullName.LeadingIcon = null;
            this.txtFullName.Location = new System.Drawing.Point(30, 17);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PrefixSuffixText = null;
            this.txtFullName.ReadOnly = false;
            this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(358, 48);
            this.txtFullName.TabIndex = 22;
            this.txtFullName.TabStop = false;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.TrailingIcon = null;
            this.txtFullName.UseAccent = false;
            this.txtFullName.UseSystemPasswordChar = false;
            // 
            // materialCardMain
            // 
            this.materialCardMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardMain.Controls.Add(this.txtPassword);
            this.materialCardMain.Controls.Add(this.txtEmployeeNumber);
            this.materialCardMain.Controls.Add(this.txtAddress);
            this.materialCardMain.Controls.Add(this.txtContactNumber);
            this.materialCardMain.Controls.Add(this.txtPositions);
            this.materialCardMain.Controls.Add(this.txtEmail);
            this.materialCardMain.Controls.Add(this.txtFullName);
            this.materialCardMain.Depth = 0;
            this.materialCardMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardMain.Location = new System.Drawing.Point(18, 14);
            this.materialCardMain.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardMain.Name = "materialCardMain";
            this.materialCardMain.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardMain.Size = new System.Drawing.Size(419, 458);
            this.materialCardMain.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(30, 379);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(358, 48);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseAccent = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.AnimateReadOnly = false;
            this.txtEmployeeNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmployeeNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeeNumber.Depth = 0;
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeNumber.HideSelection = true;
            this.txtEmployeeNumber.Hint = "Employee Number";
            this.txtEmployeeNumber.LeadingIcon = null;
            this.txtEmployeeNumber.Location = new System.Drawing.Point(30, 325);
            this.txtEmployeeNumber.MaxLength = 32767;
            this.txtEmployeeNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.PasswordChar = '\0';
            this.txtEmployeeNumber.PrefixSuffixText = null;
            this.txtEmployeeNumber.ReadOnly = false;
            this.txtEmployeeNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmployeeNumber.SelectedText = "";
            this.txtEmployeeNumber.SelectionLength = 0;
            this.txtEmployeeNumber.SelectionStart = 0;
            this.txtEmployeeNumber.ShortcutsEnabled = true;
            this.txtEmployeeNumber.Size = new System.Drawing.Size(358, 48);
            this.txtEmployeeNumber.TabIndex = 27;
            this.txtEmployeeNumber.TabStop = false;
            this.txtEmployeeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeNumber.TrailingIcon = null;
            this.txtEmployeeNumber.UseAccent = false;
            this.txtEmployeeNumber.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.HideSelection = true;
            this.txtAddress.Hint = "Address";
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(30, 235);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PrefixSuffixText = null;
            this.txtAddress.ReadOnly = false;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(358, 48);
            this.txtAddress.TabIndex = 26;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseAccent = false;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.AnimateReadOnly = false;
            this.txtContactNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContactNumber.Depth = 0;
            this.txtContactNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContactNumber.HideSelection = true;
            this.txtContactNumber.Hint = "Contact Number";
            this.txtContactNumber.LeadingIcon = null;
            this.txtContactNumber.Location = new System.Drawing.Point(30, 180);
            this.txtContactNumber.MaxLength = 32767;
            this.txtContactNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.PrefixSuffixText = null;
            this.txtContactNumber.ReadOnly = false;
            this.txtContactNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.SelectionLength = 0;
            this.txtContactNumber.SelectionStart = 0;
            this.txtContactNumber.ShortcutsEnabled = true;
            this.txtContactNumber.Size = new System.Drawing.Size(358, 48);
            this.txtContactNumber.TabIndex = 25;
            this.txtContactNumber.TabStop = false;
            this.txtContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContactNumber.TrailingIcon = null;
            this.txtContactNumber.UseAccent = false;
            this.txtContactNumber.UseSystemPasswordChar = false;
            // 
            // txtPositions
            // 
            this.txtPositions.AutoResize = false;
            this.txtPositions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPositions.Depth = 0;
            this.txtPositions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtPositions.DropDownHeight = 174;
            this.txtPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPositions.DropDownWidth = 121;
            this.txtPositions.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtPositions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPositions.FormattingEnabled = true;
            this.txtPositions.Hint = "Positions";
            this.txtPositions.IntegralHeight = false;
            this.txtPositions.ItemHeight = 43;
            this.txtPositions.Items.AddRange(new object[] {
            "Admin Staff",
            "Cashier Staff"});
            this.txtPositions.Location = new System.Drawing.Point(30, 71);
            this.txtPositions.MaxDropDownItems = 4;
            this.txtPositions.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPositions.Name = "txtPositions";
            this.txtPositions.Size = new System.Drawing.Size(358, 49);
            this.txtPositions.StartIndex = 0;
            this.txtPositions.TabIndex = 24;
            this.txtPositions.UseAccent = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(30, 126);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(358, 48);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseAccent = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(455, 542);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialCardMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditAccount";
            this.Text = "Edit Account";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.materialCardMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox2 txtFullName;
        private MaterialSkin.Controls.MaterialCard materialCardMain;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmployeeNumber;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialTextBox2 txtContactNumber;
        private MaterialSkin.Controls.MaterialComboBox txtPositions;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}