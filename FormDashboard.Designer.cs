namespace HotelManagement
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMove = new System.Windows.Forms.Panel();
            this.BtnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCustomerRegister = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.uC_AddRoom1 = new HotelManagement.User_Controls.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMove);
            this.panel1.Controls.Add(this.BtnEmployee);
            this.panel1.Controls.Add(this.BtnCustomerDetails);
            this.panel1.Controls.Add(this.BtnCheckOut);
            this.panel1.Controls.Add(this.BtnCustomerRegister);
            this.panel1.Controls.Add(this.BtnAddRoom);
            this.panel1.Location = new System.Drawing.Point(70, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1544, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMove.Location = new System.Drawing.Point(43, 113);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(224, 5);
            this.panelMove.TabIndex = 0;
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.BorderRadius = 26;
            this.BtnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnEmployee.CheckedState.FillColor = System.Drawing.Color.Cornsilk;
            this.BtnEmployee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEmployee.FillColor = System.Drawing.Color.Teal;
            this.BtnEmployee.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.ForeColor = System.Drawing.Color.White;
            this.BtnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmployee.Image")));
            this.BtnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnEmployee.Location = new System.Drawing.Point(1271, 28);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(262, 85);
            this.BtnEmployee.TabIndex = 4;
            this.BtnEmployee.Text = "Employee";
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // BtnCustomerDetails
            // 
            this.BtnCustomerDetails.BorderRadius = 26;
            this.BtnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCustomerDetails.CheckedState.FillColor = System.Drawing.Color.Cornsilk;
            this.BtnCustomerDetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCustomerDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomerDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomerDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomerDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCustomerDetails.FillColor = System.Drawing.Color.Teal;
            this.BtnCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerDetails.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomerDetails.Image")));
            this.BtnCustomerDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCustomerDetails.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnCustomerDetails.Location = new System.Drawing.Point(930, 26);
            this.BtnCustomerDetails.Name = "BtnCustomerDetails";
            this.BtnCustomerDetails.Size = new System.Drawing.Size(335, 85);
            this.BtnCustomerDetails.TabIndex = 3;
            this.BtnCustomerDetails.Text = "Customer Details";
            this.BtnCustomerDetails.Click += new System.EventHandler(this.BtnCustomerDetails_Click);
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.BorderRadius = 26;
            this.BtnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCheckOut.CheckedState.FillColor = System.Drawing.Color.Cornsilk;
            this.BtnCheckOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCheckOut.FillColor = System.Drawing.Color.Teal;
            this.BtnCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckOut.ForeColor = System.Drawing.Color.White;
            this.BtnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnCheckOut.Image")));
            this.BtnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnCheckOut.Location = new System.Drawing.Point(661, 26);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(263, 85);
            this.BtnCheckOut.TabIndex = 2;
            this.BtnCheckOut.Text = "Check Out";
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // BtnCustomerRegister
            // 
            this.BtnCustomerRegister.BorderRadius = 26;
            this.BtnCustomerRegister.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCustomerRegister.CheckedState.FillColor = System.Drawing.Color.Cornsilk;
            this.BtnCustomerRegister.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCustomerRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomerRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomerRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomerRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCustomerRegister.FillColor = System.Drawing.Color.Teal;
            this.BtnCustomerRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerRegister.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerRegister.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomerRegister.Image")));
            this.BtnCustomerRegister.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnCustomerRegister.Location = new System.Drawing.Point(299, 28);
            this.BtnCustomerRegister.Name = "BtnCustomerRegister";
            this.BtnCustomerRegister.Size = new System.Drawing.Size(356, 85);
            this.BtnCustomerRegister.TabIndex = 1;
            this.BtnCustomerRegister.Text = "Customer Registration";
            this.BtnCustomerRegister.Click += new System.EventHandler(this.BtnCustomerRegister_Click);
            // 
            // BtnAddRoom
            // 
            this.BtnAddRoom.BorderRadius = 26;
            this.BtnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAddRoom.CheckedState.FillColor = System.Drawing.Color.Cornsilk;
            this.BtnAddRoom.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddRoom.FillColor = System.Drawing.Color.Teal;
            this.BtnAddRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddRoom.ForeColor = System.Drawing.Color.White;
            this.BtnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddRoom.Image")));
            this.BtnAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAddRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnAddRoom.Location = new System.Drawing.Point(18, 26);
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.Size = new System.Drawing.Size(275, 85);
            this.BtnAddRoom.TabIndex = 0;
            this.BtnAddRoom.Text = "Add Room";
            this.BtnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(12, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1629, 554);
            this.panel2.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.Teal;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnExit.Location = new System.Drawing.Point(8, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(56, 58);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMinimize.FillColor = System.Drawing.Color.Teal;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMinimize.Location = new System.Drawing.Point(8, 76);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(56, 57);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(153, 22);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1464, 552);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.Visible = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1615, 676);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Guna.UI2.WinForms.Guna2Button BtnMinimize;
        private Guna.UI2.WinForms.Guna2Button BtnAddRoom;
        private Guna.UI2.WinForms.Guna2Button BtnCustomerRegister;
        private Guna.UI2.WinForms.Guna2Button BtnEmployee;
        private Guna.UI2.WinForms.Guna2Button BtnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button BtnCheckOut;
        private System.Windows.Forms.Panel panelMove;
        private User_Controls.UC_AddRoom uC_AddRoom1;
    }
}