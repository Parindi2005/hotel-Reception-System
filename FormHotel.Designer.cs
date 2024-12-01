namespace HotelManagement
{
    partial class FormHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelAcceptance = new System.Windows.Forms.Label();
            this.labelForget_Psswd = new System.Windows.Forms.Label();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelUserLogIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BtnCancle);
            this.panel1.Controls.Add(this.labelAcceptance);
            this.panel1.Controls.Add(this.labelForget_Psswd);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.labelUserLogIn);
            this.panel1.Location = new System.Drawing.Point(246, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 492);
            this.panel1.TabIndex = 0;
            // 
            // BtnCancle
            // 
            this.BtnCancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCancle.FillColor = System.Drawing.Color.White;
            this.BtnCancle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancle.ForeColor = System.Drawing.Color.White;
            this.BtnCancle.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancle.Image")));
            this.BtnCancle.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnCancle.Location = new System.Drawing.Point(3, 3);
            this.BtnCancle.MaximumSize = new System.Drawing.Size(60, 60);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnCancle.Size = new System.Drawing.Size(39, 39);
            this.BtnCancle.TabIndex = 7;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // labelAcceptance
            // 
            this.labelAcceptance.AutoSize = true;
            this.labelAcceptance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcceptance.ForeColor = System.Drawing.Color.Gray;
            this.labelAcceptance.Location = new System.Drawing.Point(115, 456);
            this.labelAcceptance.Name = "labelAcceptance";
            this.labelAcceptance.Size = new System.Drawing.Size(531, 36);
            this.labelAcceptance.TabIndex = 6;
            this.labelAcceptance.Text = "* You will accept the terms and conditions when you login using valid creitionals" +
    ".\r\n\r\n";
            // 
            // labelForget_Psswd
            // 
            this.labelForget_Psswd.AutoSize = true;
            this.labelForget_Psswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForget_Psswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelForget_Psswd.Location = new System.Drawing.Point(396, 386);
            this.labelForget_Psswd.Name = "labelForget_Psswd";
            this.labelForget_Psswd.Size = new System.Drawing.Size(213, 18);
            this.labelForget_Psswd.TabIndex = 5;
            this.labelForget_Psswd.Text = "Forget Username or Password";
            this.labelForget_Psswd.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderRadius = 22;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.DarkKhaki;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLogin.Location = new System.Drawing.Point(391, 309);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(218, 53);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.Black;
            this.TxtPassword.BorderRadius = 18;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FillColor = System.Drawing.Color.DarkCyan;
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtPassword.IconLeft")));
            this.TxtPassword.IconLeftSize = new System.Drawing.Size(35, 35);
            this.TxtPassword.Location = new System.Drawing.Point(309, 211);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PlaceholderText = "Password";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(375, 67);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BorderColor = System.Drawing.Color.Black;
            this.TxtUserName.BorderRadius = 18;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.DefaultText = "";
            this.TxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.FillColor = System.Drawing.Color.DarkCyan;
            this.TxtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtUserName.IconLeft")));
            this.TxtUserName.IconLeftSize = new System.Drawing.Size(35, 35);
            this.TxtUserName.Location = new System.Drawing.Point(309, 123);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.PlaceholderText = "User Name";
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.Size = new System.Drawing.Size(375, 65);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUserName.TextChanged += new System.EventHandler(this.guna2TextBoxUserName_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 99);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(252, 286);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // labelUserLogIn
            // 
            this.labelUserLogIn.AutoSize = true;
            this.labelUserLogIn.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLogIn.Location = new System.Drawing.Point(420, 54);
            this.labelUserLogIn.Name = "labelUserLogIn";
            this.labelUserLogIn.Size = new System.Drawing.Size(120, 28);
            this.labelUserLogIn.TabIndex = 0;
            this.labelUserLogIn.Text = "User Login";
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1216, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserLogIn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserName;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private System.Windows.Forms.Label labelAcceptance;
        private System.Windows.Forms.Label labelForget_Psswd;
        private Guna.UI2.WinForms.Guna2CircleButton BtnCancle;
    }
}