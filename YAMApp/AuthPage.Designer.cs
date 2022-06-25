namespace YAMApp
{
    partial class AuthPage
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
            this.CloseButtton = new FontAwesome.Sharp.IconButton();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.UNameInsert = new System.Windows.Forms.TextBox();
            this.UNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UPINInsert = new System.Windows.Forms.TextBox();
            this.UPINLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Welcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AuthButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // CloseButtton
            // 
            this.CloseButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButtton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButtton.IconColor = System.Drawing.Color.White;
            this.CloseButtton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButtton.Location = new System.Drawing.Point(732, -1);
            this.CloseButtton.Name = "CloseButtton";
            this.CloseButtton.Size = new System.Drawing.Size(43, 45);
            this.CloseButtton.TabIndex = 0;
            this.CloseButtton.UseVisualStyleBackColor = true;
            this.CloseButtton.Click += new System.EventHandler(this.CloseButtton_Click);
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MinButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinButton.IconColor = System.Drawing.Color.White;
            this.MinButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinButton.Location = new System.Drawing.Point(693, -1);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(43, 45);
            this.MinButton.TabIndex = 1;
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-273, -1);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(534, 452);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // UNameInsert
            // 
            this.UNameInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameInsert.Location = new System.Drawing.Point(456, 203);
            this.UNameInsert.Name = "UNameInsert";
            this.UNameInsert.Size = new System.Drawing.Size(140, 30);
            this.UNameInsert.TabIndex = 3;
            this.UNameInsert.TextChanged += new System.EventHandler(this.UNameInsert_TextChanged);
            // 
            // UNameLabel
            // 
            this.UNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UNameLabel.Location = new System.Drawing.Point(345, 203);
            this.UNameLabel.Name = "UNameLabel";
            this.UNameLabel.Size = new System.Drawing.Size(90, 30);
            this.UNameLabel.TabIndex = 4;
            this.UNameLabel.Text = "Username";
            // 
            // UPINInsert
            // 
            this.UPINInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPINInsert.Location = new System.Drawing.Point(456, 252);
            this.UPINInsert.Name = "UPINInsert";
            this.UPINInsert.Size = new System.Drawing.Size(140, 30);
            this.UPINInsert.TabIndex = 5;
            this.UPINInsert.TextChanged += new System.EventHandler(this.UPINInsert_TextChanged);
            // 
            // UPINLabel
            // 
            this.UPINLabel.BackColor = System.Drawing.Color.Transparent;
            this.UPINLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPINLabel.Location = new System.Drawing.Point(345, 252);
            this.UPINLabel.Name = "UPINLabel";
            this.UPINLabel.Size = new System.Drawing.Size(34, 30);
            this.UPINLabel.TabIndex = 6;
            this.UPINLabel.Text = "PIN";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(331, 114);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(388, 39);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Your Account Management App";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(267, 113);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 40);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.Color.RoyalBlue;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome.Location = new System.Drawing.Point(12, 203);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(195, 56);
            this.Welcome.TabIndex = 23;
            this.Welcome.Text = "WELCOME";
            // 
            // AuthButton
            // 
            this.AuthButton.AutoRoundedCorners = true;
            this.AuthButton.BorderRadius = 24;
            this.AuthButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AuthButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AuthButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AuthButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AuthButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthButton.ForeColor = System.Drawing.Color.White;
            this.AuthButton.Location = new System.Drawing.Point(398, 306);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(142, 50);
            this.AuthButton.TabIndex = 24;
            this.AuthButton.Text = "Auth";
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // AuthPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.UPINLabel);
            this.Controls.Add(this.UPINInsert);
            this.Controls.Add(this.UNameLabel);
            this.Controls.Add(this.UNameInsert);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.CloseButtton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UNameLabel;
        private TextBox UNameInsert;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton CloseButtton;
        private TextBox UPINInsert;
        private Guna.UI2.WinForms.Guna2HtmlLabel UPINLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Welcome;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2TileButton AuthButton;
    }
}