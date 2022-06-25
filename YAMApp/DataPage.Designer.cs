namespace YAMApp
{
    partial class DataPage
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
            this.AccUIDNonInsert = new System.Windows.Forms.TextBox();
            this.UIDLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UserIcon = new FontAwesome.Sharp.IconButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AccPhoneInsert = new System.Windows.Forms.TextBox();
            this.AccEmailInsert = new System.Windows.Forms.TextBox();
            this.AccUPassInsert = new System.Windows.Forms.TextBox();
            this.AccUNameInsert = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.UPassLabel = new System.Windows.Forms.Label();
            this.UNameLabel = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.AccDateLabel = new System.Windows.Forms.Label();
            this.AccUpdDateLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.CloseButtton = new FontAwesome.Sharp.IconButton();
            this.LabelData = new System.Windows.Forms.Label();
            this.SaveUpdateButton = new System.Windows.Forms.Button();
            this.AccTypeInsertCBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AccDescInsert = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.AccPlatfLabel = new System.Windows.Forms.Label();
            this.AccPlatfInsert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccUIDNonInsert
            // 
            this.AccUIDNonInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccUIDNonInsert.Location = new System.Drawing.Point(150, 117);
            this.AccUIDNonInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccUIDNonInsert.Name = "AccUIDNonInsert";
            this.AccUIDNonInsert.Size = new System.Drawing.Size(273, 30);
            this.AccUIDNonInsert.TabIndex = 63;
            // 
            // UIDLabel
            // 
            this.UIDLabel.AutoSize = true;
            this.UIDLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.UIDLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UIDLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.UIDLabel.Location = new System.Drawing.Point(47, 121);
            this.UIDLabel.Name = "UIDLabel";
            this.UIDLabel.Size = new System.Drawing.Size(91, 23);
            this.UIDLabel.TabIndex = 62;
            this.UIDLabel.Text = "UID Akun";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.EmailLabel.Location = new System.Drawing.Point(47, 241);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(56, 23);
            this.EmailLabel.TabIndex = 58;
            this.EmailLabel.Text = "Email";
            // 
            // UserIcon
            // 
            this.UserIcon.BackColor = System.Drawing.Color.RoyalBlue;
            this.UserIcon.FlatAppearance.BorderSize = 0;
            this.UserIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UserIcon.IconColor = System.Drawing.Color.LightCyan;
            this.UserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserIcon.Location = new System.Drawing.Point(22, 41);
            this.UserIcon.Margin = new System.Windows.Forms.Padding(2);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(120, 59);
            this.UserIcon.TabIndex = 57;
            this.UserIcon.UseVisualStyleBackColor = false;
            this.UserIcon.Click += new System.EventHandler(this.UserIcon_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LightCyan;
            this.SaveButton.Location = new System.Drawing.Point(224, 446);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 28);
            this.SaveButton.TabIndex = 55;
            this.SaveButton.Text = "Simpan";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AccPhoneInsert
            // 
            this.AccPhoneInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccPhoneInsert.Location = new System.Drawing.Point(150, 277);
            this.AccPhoneInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccPhoneInsert.Name = "AccPhoneInsert";
            this.AccPhoneInsert.Size = new System.Drawing.Size(273, 30);
            this.AccPhoneInsert.TabIndex = 53;
            // 
            // AccEmailInsert
            // 
            this.AccEmailInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccEmailInsert.Location = new System.Drawing.Point(150, 237);
            this.AccEmailInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccEmailInsert.Name = "AccEmailInsert";
            this.AccEmailInsert.Size = new System.Drawing.Size(273, 30);
            this.AccEmailInsert.TabIndex = 52;
            // 
            // AccUPassInsert
            // 
            this.AccUPassInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccUPassInsert.Location = new System.Drawing.Point(150, 197);
            this.AccUPassInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccUPassInsert.Name = "AccUPassInsert";
            this.AccUPassInsert.Size = new System.Drawing.Size(273, 30);
            this.AccUPassInsert.TabIndex = 51;
            // 
            // AccUNameInsert
            // 
            this.AccUNameInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccUNameInsert.Location = new System.Drawing.Point(150, 157);
            this.AccUNameInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccUNameInsert.Name = "AccUNameInsert";
            this.AccUNameInsert.Size = new System.Drawing.Size(273, 30);
            this.AccUNameInsert.TabIndex = 50;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ContactLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.ContactLabel.Location = new System.Drawing.Point(47, 281);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(76, 23);
            this.ContactLabel.TabIndex = 47;
            this.ContactLabel.Text = "No.Telp";
            // 
            // UPassLabel
            // 
            this.UPassLabel.AutoSize = true;
            this.UPassLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.UPassLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UPassLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.UPassLabel.Location = new System.Drawing.Point(47, 201);
            this.UPassLabel.Name = "UPassLabel";
            this.UPassLabel.Size = new System.Drawing.Size(89, 23);
            this.UPassLabel.TabIndex = 46;
            this.UPassLabel.Text = "Password";
            // 
            // UNameLabel
            // 
            this.UNameLabel.AutoSize = true;
            this.UNameLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.UNameLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UNameLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.UNameLabel.Location = new System.Drawing.Point(47, 161);
            this.UNameLabel.Name = "UNameLabel";
            this.UNameLabel.Size = new System.Drawing.Size(95, 23);
            this.UNameLabel.TabIndex = 45;
            this.UNameLabel.Text = "Username";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AccDateLabel
            // 
            this.AccDateLabel.AutoSize = true;
            this.AccDateLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccDateLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.AccDateLabel.Location = new System.Drawing.Point(7, 488);
            this.AccDateLabel.Name = "AccDateLabel";
            this.AccDateLabel.Size = new System.Drawing.Size(116, 17);
            this.AccDateLabel.TabIndex = 75;
            this.AccDateLabel.Text = "Tanggal Input: -";
            this.AccDateLabel.Click += new System.EventHandler(this.AccDateLabel_Click);
            // 
            // AccUpdDateLabel
            // 
            this.AccUpdDateLabel.AutoSize = true;
            this.AccUpdDateLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccUpdDateLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.AccUpdDateLabel.Location = new System.Drawing.Point(6, 505);
            this.AccUpdDateLabel.Name = "AccUpdDateLabel";
            this.AccUpdDateLabel.Size = new System.Drawing.Size(117, 17);
            this.AccUpdDateLabel.TabIndex = 76;
            this.AccUpdDateLabel.Text = "Tanggal Ubah: -";
            // 
            // EditButton
            // 
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.LightCyan;
            this.EditButton.Location = new System.Drawing.Point(150, 446);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(115, 28);
            this.EditButton.TabIndex = 77;
            this.EditButton.Text = "Ubah";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightCyan;
            this.DeleteButton.Location = new System.Drawing.Point(308, 446);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(115, 28);
            this.DeleteButton.TabIndex = 78;
            this.DeleteButton.Text = "Hapus";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MinButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinButton.IconColor = System.Drawing.Color.LightCyan;
            this.MinButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinButton.Location = new System.Drawing.Point(386, 4);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(43, 45);
            this.MinButton.TabIndex = 82;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButtton
            // 
            this.CloseButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CloseButtton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButtton.IconColor = System.Drawing.Color.LightCyan;
            this.CloseButtton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButtton.Location = new System.Drawing.Point(435, 4);
            this.CloseButtton.Name = "CloseButtton";
            this.CloseButtton.Size = new System.Drawing.Size(43, 45);
            this.CloseButtton.TabIndex = 81;
            this.CloseButtton.UseVisualStyleBackColor = true;
            this.CloseButtton.Click += new System.EventHandler(this.CloseButtton_Click);
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelData.ForeColor = System.Drawing.Color.LightCyan;
            this.LabelData.Location = new System.Drawing.Point(200, 50);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(136, 32);
            this.LabelData.TabIndex = 83;
            this.LabelData.Text = "Label Data";
            // 
            // SaveUpdateButton
            // 
            this.SaveUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveUpdateButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveUpdateButton.ForeColor = System.Drawing.Color.LightCyan;
            this.SaveUpdateButton.Location = new System.Drawing.Point(189, 446);
            this.SaveUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveUpdateButton.Name = "SaveUpdateButton";
            this.SaveUpdateButton.Size = new System.Drawing.Size(189, 28);
            this.SaveUpdateButton.TabIndex = 84;
            this.SaveUpdateButton.Text = "Simpan Perubahan";
            this.SaveUpdateButton.UseVisualStyleBackColor = true;
            this.SaveUpdateButton.Click += new System.EventHandler(this.SaveUpdateButton_Click);
            // 
            // AccTypeInsertCBox
            // 
            this.AccTypeInsertCBox.FormattingEnabled = true;
            this.AccTypeInsertCBox.Location = new System.Drawing.Point(150, 397);
            this.AccTypeInsertCBox.Name = "AccTypeInsertCBox";
            this.AccTypeInsertCBox.Size = new System.Drawing.Size(153, 28);
            this.AccTypeInsertCBox.TabIndex = 86;
            this.AccTypeInsertCBox.SelectedIndexChanged += new System.EventHandler(this.AccTypeInsertCBox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.TypeLabel.Location = new System.Drawing.Point(49, 399);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(95, 23);
            this.TypeLabel.TabIndex = 87;
            this.TypeLabel.Text = "Tipe Akun";
            // 
            // AccDescInsert
            // 
            this.AccDescInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccDescInsert.Location = new System.Drawing.Point(150, 317);
            this.AccDescInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccDescInsert.Name = "AccDescInsert";
            this.AccDescInsert.Size = new System.Drawing.Size(273, 30);
            this.AccDescInsert.TabIndex = 88;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.DescLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.DescLabel.Location = new System.Drawing.Point(47, 321);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(86, 23);
            this.DescLabel.TabIndex = 89;
            this.DescLabel.Text = "Deskripsi";
            // 
            // AccPlatfLabel
            // 
            this.AccPlatfLabel.AutoSize = true;
            this.AccPlatfLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.AccPlatfLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccPlatfLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.AccPlatfLabel.Location = new System.Drawing.Point(47, 359);
            this.AccPlatfLabel.Name = "AccPlatfLabel";
            this.AccPlatfLabel.Size = new System.Drawing.Size(83, 23);
            this.AccPlatfLabel.TabIndex = 91;
            this.AccPlatfLabel.Text = "Platform";
            // 
            // AccPlatfInsert
            // 
            this.AccPlatfInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccPlatfInsert.Location = new System.Drawing.Point(150, 357);
            this.AccPlatfInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccPlatfInsert.Name = "AccPlatfInsert";
            this.AccPlatfInsert.Size = new System.Drawing.Size(273, 30);
            this.AccPlatfInsert.TabIndex = 90;
            // 
            // DataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(481, 531);
            this.Controls.Add(this.AccPlatfLabel);
            this.Controls.Add(this.AccPlatfInsert);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.AccDescInsert);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AccTypeInsertCBox);
            this.Controls.Add(this.SaveUpdateButton);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.CloseButtton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AccUpdDateLabel);
            this.Controls.Add(this.AccDateLabel);
            this.Controls.Add(this.AccUIDNonInsert);
            this.Controls.Add(this.UIDLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AccPhoneInsert);
            this.Controls.Add(this.AccEmailInsert);
            this.Controls.Add(this.AccUPassInsert);
            this.Controls.Add(this.AccUNameInsert);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.UPassLabel);
            this.Controls.Add(this.UNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPage";
            this.Load += new System.EventHandler(this.DataPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox AccUIDNonInsert;
        private Label UIDLabel;
        private Label EmailLabel;
        private FontAwesome.Sharp.IconButton UserIcon;
        public Button SaveButton;
        private TextBox AccPhoneInsert;
        private TextBox AccEmailInsert;
        private TextBox AccUPassInsert;
        private TextBox AccUNameInsert;
        private Label ContactLabel;
        private Label UPassLabel;
        private Label UNameLabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label AccUpdDateLabel;
        private Label AccDateLabel;
        public Button DeleteButton;
        public Button EditButton;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton CloseButtton;
        private Label LabelData;
        public Button SaveUpdateButton;
        private Label TypeLabel;
        private ComboBox AccTypeInsertCBox;
        private Label DescLabel;
        private TextBox AccDescInsert;
        private Label AccPlatfLabel;
        private TextBox AccPlatfInsert;
    }
}