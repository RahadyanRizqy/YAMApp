namespace YAMApp
{
    partial class ShowPage
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.LeftLayoulPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.log = new FontAwesome.Sharp.IconButton();
            this.MenuShowButton = new FontAwesome.Sharp.IconButton();
            this.MenuHomeButton = new FontAwesome.Sharp.IconButton();
            this.MenuNoteButton = new FontAwesome.Sharp.IconButton();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.CloseButtton = new FontAwesome.Sharp.IconButton();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.SelectedAcc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AccTypeLabelComboBox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FindByDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FindByUIDLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.UserGreet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FindByUIDInsert = new System.Windows.Forms.TextBox();
            this.AccTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DatePickerComboBox = new System.Windows.Forms.DateTimePicker();
            this.FindButtonByUID = new Guna.UI2.WinForms.Guna2Button();
            this.FindButtonByDate = new Guna.UI2.WinForms.Guna2Button();
            this.FindButtonByType = new Guna.UI2.WinForms.Guna2Button();
            this.AddNewDataButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewDetail = new Guna.UI2.WinForms.Guna2Button();
            this.LeftLayoulPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LeftLayoulPanel
            // 
            this.LeftLayoulPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LeftLayoulPanel.Controls.Add(this.log);
            this.LeftLayoulPanel.Controls.Add(this.MenuShowButton);
            this.LeftLayoulPanel.Controls.Add(this.MenuHomeButton);
            this.LeftLayoulPanel.Controls.Add(this.MenuNoteButton);
            this.LeftLayoulPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftLayoulPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftLayoulPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftLayoulPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftLayoulPanel.Name = "LeftLayoulPanel";
            this.LeftLayoulPanel.Size = new System.Drawing.Size(190, 658);
            this.LeftLayoulPanel.TabIndex = 6;
            // 
            // log
            // 
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.log.IconColor = System.Drawing.Color.White;
            this.log.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log.IconSize = 60;
            this.log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log.Location = new System.Drawing.Point(3, 4);
            this.log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(185, 135);
            this.log.TabIndex = 2;
            this.log.Text = "Management Account";
            this.log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.log.UseVisualStyleBackColor = true;
            // 
            // MenuShowButton
            // 
            this.MenuShowButton.FlatAppearance.BorderSize = 0;
            this.MenuShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuShowButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MenuShowButton.ForeColor = System.Drawing.Color.White;
            this.MenuShowButton.IconChar = FontAwesome.Sharp.IconChar.List;
            this.MenuShowButton.IconColor = System.Drawing.Color.Azure;
            this.MenuShowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuShowButton.IconSize = 30;
            this.MenuShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuShowButton.Location = new System.Drawing.Point(3, 147);
            this.MenuShowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuShowButton.Name = "MenuShowButton";
            this.MenuShowButton.Size = new System.Drawing.Size(185, 70);
            this.MenuShowButton.TabIndex = 4;
            this.MenuShowButton.Text = "Show ";
            this.MenuShowButton.UseVisualStyleBackColor = true;
            this.MenuShowButton.Click += new System.EventHandler(this.MenuShowButton_Click);
            // 
            // MenuHomeButton
            // 
            this.MenuHomeButton.FlatAppearance.BorderSize = 0;
            this.MenuHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuHomeButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MenuHomeButton.ForeColor = System.Drawing.Color.White;
            this.MenuHomeButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.MenuHomeButton.IconColor = System.Drawing.Color.Azure;
            this.MenuHomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuHomeButton.IconSize = 30;
            this.MenuHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuHomeButton.Location = new System.Drawing.Point(3, 225);
            this.MenuHomeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuHomeButton.Name = "MenuHomeButton";
            this.MenuHomeButton.Size = new System.Drawing.Size(185, 70);
            this.MenuHomeButton.TabIndex = 6;
            this.MenuHomeButton.Text = "Logout";
            this.MenuHomeButton.UseVisualStyleBackColor = true;
            this.MenuHomeButton.Click += new System.EventHandler(this.MenuHomeButton_Click_1);
            // 
            // MenuNoteButton
            // 
            this.MenuNoteButton.FlatAppearance.BorderSize = 0;
            this.MenuNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuNoteButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MenuNoteButton.ForeColor = System.Drawing.Color.White;
            this.MenuNoteButton.IconChar = FontAwesome.Sharp.IconChar.Neos;
            this.MenuNoteButton.IconColor = System.Drawing.Color.Azure;
            this.MenuNoteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuNoteButton.IconSize = 30;
            this.MenuNoteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuNoteButton.Location = new System.Drawing.Point(3, 303);
            this.MenuNoteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuNoteButton.Name = "MenuNoteButton";
            this.MenuNoteButton.Size = new System.Drawing.Size(185, 70);
            this.MenuNoteButton.TabIndex = 3;
            this.MenuNoteButton.Text = "Notes";
            this.MenuNoteButton.UseVisualStyleBackColor = true;
            this.MenuNoteButton.Click += new System.EventHandler(this.MenuNoteButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MinButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinButton.IconColor = System.Drawing.Color.LightCyan;
            this.MinButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinButton.Location = new System.Drawing.Point(1322, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(43, 45);
            this.MinButton.TabIndex = 8;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButtton
            // 
            this.CloseButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButtton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButtton.IconColor = System.Drawing.Color.LightCyan;
            this.CloseButtton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButtton.Location = new System.Drawing.Point(1362, 0);
            this.CloseButtton.Name = "CloseButtton";
            this.CloseButtton.Size = new System.Drawing.Size(43, 45);
            this.CloseButtton.TabIndex = 7;
            this.CloseButtton.UseVisualStyleBackColor = true;
            this.CloseButtton.Click += new System.EventHandler(this.CloseButtton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoRoundedCorners = true;
            this.UpdateButton.BorderRadius = 27;
            this.UpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(1080, 590);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(155, 56);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Ubah/Perbarui";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoRoundedCorners = true;
            this.DeleteButton.BorderRadius = 27;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(1241, 590);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(155, 56);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Hapus";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SelectedAcc
            // 
            this.SelectedAcc.BackColor = System.Drawing.Color.Transparent;
            this.SelectedAcc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedAcc.Location = new System.Drawing.Point(195, 608);
            this.SelectedAcc.Name = "SelectedAcc";
            this.SelectedAcc.Size = new System.Drawing.Size(133, 27);
            this.SelectedAcc.TabIndex = 13;
            this.SelectedAcc.Text = "ID Akun Terpilih: ";
            // 
            // AccTypeLabelComboBox
            // 
            this.AccTypeLabelComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AccTypeLabelComboBox.Location = new System.Drawing.Point(195, 51);
            this.AccTypeLabelComboBox.Name = "AccTypeLabelComboBox";
            this.AccTypeLabelComboBox.Size = new System.Drawing.Size(121, 22);
            this.AccTypeLabelComboBox.TabIndex = 21;
            this.AccTypeLabelComboBox.Text = "Cari Dengan Tipe:";
            // 
            // FindByDateLabel
            // 
            this.FindByDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.FindByDateLabel.Location = new System.Drawing.Point(628, 52);
            this.FindByDateLabel.Name = "FindByDateLabel";
            this.FindByDateLabel.Size = new System.Drawing.Size(184, 22);
            this.FindByDateLabel.TabIndex = 22;
            this.FindByDateLabel.Text = "Cari Dengan Tanggal Input:";
            // 
            // FindByUIDLabel
            // 
            this.FindByUIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.FindByUIDLabel.Location = new System.Drawing.Point(1157, 52);
            this.FindByUIDLabel.Name = "FindByUIDLabel";
            this.FindByUIDLabel.Size = new System.Drawing.Size(117, 22);
            this.FindByUIDLabel.TabIndex = 23;
            this.FindByUIDLabel.Text = "Cari Dengan UID:";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(194, 117);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 29;
            this.dgv1.Size = new System.Drawing.Size(1202, 467);
            this.dgv1.TabIndex = 24;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // UserGreet
            // 
            this.UserGreet.BackColor = System.Drawing.Color.Transparent;
            this.UserGreet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserGreet.Location = new System.Drawing.Point(196, 12);
            this.UserGreet.Name = "UserGreet";
            this.UserGreet.Size = new System.Drawing.Size(133, 27);
            this.UserGreet.TabIndex = 25;
            this.UserGreet.Text = "Selamat Datang:";
            // 
            // FindByUIDInsert
            // 
            this.FindByUIDInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindByUIDInsert.Location = new System.Drawing.Point(1157, 80);
            this.FindByUIDInsert.Name = "FindByUIDInsert";
            this.FindByUIDInsert.Size = new System.Drawing.Size(134, 30);
            this.FindByUIDInsert.TabIndex = 31;
            // 
            // AccTypeComboBox
            // 
            this.AccTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccTypeComboBox.FormattingEnabled = true;
            this.AccTypeComboBox.Location = new System.Drawing.Point(194, 80);
            this.AccTypeComboBox.Name = "AccTypeComboBox";
            this.AccTypeComboBox.Size = new System.Drawing.Size(175, 31);
            this.AccTypeComboBox.TabIndex = 32;
            this.AccTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AccTypeComboBox_SelectedIndexChanged_1);
            // 
            // DatePickerComboBox
            // 
            this.DatePickerComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePickerComboBox.Location = new System.Drawing.Point(628, 81);
            this.DatePickerComboBox.Name = "DatePickerComboBox";
            this.DatePickerComboBox.Size = new System.Drawing.Size(289, 30);
            this.DatePickerComboBox.TabIndex = 33;
            this.DatePickerComboBox.ValueChanged += new System.EventHandler(this.DatePickerComboBox_ValueChanged_1);
            // 
            // FindButtonByUID
            // 
            this.FindButtonByUID.AutoRoundedCorners = true;
            this.FindButtonByUID.BorderRadius = 14;
            this.FindButtonByUID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FindButtonByUID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FindButtonByUID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindButtonByUID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FindButtonByUID.FillColor = System.Drawing.Color.RoyalBlue;
            this.FindButtonByUID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindButtonByUID.ForeColor = System.Drawing.Color.White;
            this.FindButtonByUID.Location = new System.Drawing.Point(1298, 79);
            this.FindButtonByUID.Name = "FindButtonByUID";
            this.FindButtonByUID.Size = new System.Drawing.Size(98, 31);
            this.FindButtonByUID.TabIndex = 29;
            this.FindButtonByUID.Text = "Cari";
            this.FindButtonByUID.Click += new System.EventHandler(this.FindButtonByUID_Click);
            // 
            // FindButtonByDate
            // 
            this.FindButtonByDate.AutoRoundedCorners = true;
            this.FindButtonByDate.BorderRadius = 14;
            this.FindButtonByDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FindButtonByDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FindButtonByDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindButtonByDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FindButtonByDate.FillColor = System.Drawing.Color.RoyalBlue;
            this.FindButtonByDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindButtonByDate.ForeColor = System.Drawing.Color.White;
            this.FindButtonByDate.Location = new System.Drawing.Point(923, 81);
            this.FindButtonByDate.Name = "FindButtonByDate";
            this.FindButtonByDate.Size = new System.Drawing.Size(98, 31);
            this.FindButtonByDate.TabIndex = 34;
            this.FindButtonByDate.Text = "Cari";
            this.FindButtonByDate.Click += new System.EventHandler(this.FindButtonByDate_Click);
            // 
            // FindButtonByType
            // 
            this.FindButtonByType.AutoRoundedCorners = true;
            this.FindButtonByType.BorderRadius = 14;
            this.FindButtonByType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FindButtonByType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FindButtonByType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindButtonByType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FindButtonByType.FillColor = System.Drawing.Color.RoyalBlue;
            this.FindButtonByType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindButtonByType.ForeColor = System.Drawing.Color.White;
            this.FindButtonByType.Location = new System.Drawing.Point(375, 80);
            this.FindButtonByType.Name = "FindButtonByType";
            this.FindButtonByType.Size = new System.Drawing.Size(98, 31);
            this.FindButtonByType.TabIndex = 35;
            this.FindButtonByType.Text = "Cari";
            this.FindButtonByType.Click += new System.EventHandler(this.FindButtonByType_Click);
            // 
            // AddNewDataButton
            // 
            this.AddNewDataButton.AutoRoundedCorners = true;
            this.AddNewDataButton.BorderRadius = 27;
            this.AddNewDataButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddNewDataButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddNewDataButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddNewDataButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddNewDataButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.AddNewDataButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewDataButton.ForeColor = System.Drawing.Color.White;
            this.AddNewDataButton.Location = new System.Drawing.Point(919, 590);
            this.AddNewDataButton.Name = "AddNewDataButton";
            this.AddNewDataButton.Size = new System.Drawing.Size(155, 56);
            this.AddNewDataButton.TabIndex = 36;
            this.AddNewDataButton.Text = "Input Data Baru";
            this.AddNewDataButton.Click += new System.EventHandler(this.AddNewDataButton_Click);
            // 
            // ViewDetail
            // 
            this.ViewDetail.AutoRoundedCorners = true;
            this.ViewDetail.BorderRadius = 27;
            this.ViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewDetail.FillColor = System.Drawing.Color.RoyalBlue;
            this.ViewDetail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewDetail.ForeColor = System.Drawing.Color.White;
            this.ViewDetail.Location = new System.Drawing.Point(758, 590);
            this.ViewDetail.Name = "ViewDetail";
            this.ViewDetail.Size = new System.Drawing.Size(155, 56);
            this.ViewDetail.TabIndex = 37;
            this.ViewDetail.Text = "Lihat Rincian";
            this.ViewDetail.Click += new System.EventHandler(this.ViewDetail_Click);
            // 
            // ShowPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1400, 658);
            this.Controls.Add(this.ViewDetail);
            this.Controls.Add(this.AddNewDataButton);
            this.Controls.Add(this.FindButtonByType);
            this.Controls.Add(this.FindButtonByDate);
            this.Controls.Add(this.DatePickerComboBox);
            this.Controls.Add(this.AccTypeComboBox);
            this.Controls.Add(this.FindByUIDInsert);
            this.Controls.Add(this.FindButtonByUID);
            this.Controls.Add(this.UserGreet);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.FindByUIDLabel);
            this.Controls.Add(this.FindByDateLabel);
            this.Controls.Add(this.AccTypeLabelComboBox);
            this.Controls.Add(this.LeftLayoulPanel);
            this.Controls.Add(this.SelectedAcc);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.CloseButtton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPage";
            this.Load += new System.EventHandler(this.ShowPage_Load);
            this.LeftLayoulPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FlowLayoutPanel LeftLayoulPanel;
        private FontAwesome.Sharp.IconButton log;
        public FontAwesome.Sharp.IconButton MenuNoteButton;
        private FontAwesome.Sharp.IconButton MenuShowButton;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton CloseButtton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button UpdateButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel SelectedAcc;
        private Guna.UI2.WinForms.Guna2HtmlLabel FindByDateLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel AccTypeLabelComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel FindByUIDLabel;
        private DataGridView dgv1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserGreet;
        private TextBox FindByUIDInsert;
        private ComboBox AccTypeComboBox;
        private DateTimePicker DatePickerComboBox;
        private Guna.UI2.WinForms.Guna2Button FindButtonByUID;
        private Guna.UI2.WinForms.Guna2Button FindButtonByType;
        private Guna.UI2.WinForms.Guna2Button FindButtonByDate;
        private FontAwesome.Sharp.IconButton MenuHomeButton;
        private Guna.UI2.WinForms.Guna2Button AddNewDataButton;
        private Guna.UI2.WinForms.Guna2Button ViewDetail;
    }
}