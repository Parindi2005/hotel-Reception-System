namespace HotelManagement.User_Controls
{
    partial class UC_AddRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAddRoom = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DataGridView_2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelBed = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.TxtRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmBoxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmBoxBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddRoom
            // 
            this.labelAddRoom.AutoSize = true;
            this.labelAddRoom.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddRoom.Location = new System.Drawing.Point(32, 27);
            this.labelAddRoom.Name = "labelAddRoom";
            this.labelAddRoom.Size = new System.Drawing.Size(260, 45);
            this.labelAddRoom.TabIndex = 0;
            this.labelAddRoom.Text = "Add New Room";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(194, 196);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(240, 150);
            this.guna2DataGridView1.TabIndex = 1;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DataGridView_2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_2.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_2.Location = new System.Drawing.Point(40, 85);
            this.DataGridView_2.Name = "DataGridView_2";
            this.DataGridView_2.RowHeadersVisible = false;
            this.DataGridView_2.RowHeadersWidth = 51;
            this.DataGridView_2.RowTemplate.Height = 24;
            this.DataGridView_2.Size = new System.Drawing.Size(703, 415);
            this.DataGridView_2.TabIndex = 2;
            this.DataGridView_2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_2.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView_2.ThemeStyle.ReadOnly = false;
            this.DataGridView_2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_2.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellContentClick);
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(938, 187);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(120, 27);
            this.labelRoomType.TabIndex = 4;
            this.labelRoomType.Text = "Room Type";
            // 
            // labelBed
            // 
            this.labelBed.AutoSize = true;
            this.labelBed.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBed.Location = new System.Drawing.Point(937, 271);
            this.labelBed.Name = "labelBed";
            this.labelBed.Size = new System.Drawing.Size(48, 27);
            this.labelBed.TabIndex = 5;
            this.labelBed.Text = "Bed";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(938, 360);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(72, 27);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(938, 91);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(144, 27);
            this.labelRoomNumber.TabIndex = 7;
            this.labelRoomNumber.Text = "Room Number";
            // 
            // TxtRoomNumber
            // 
            this.TxtRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRoomNumber.DefaultText = "";
            this.TxtRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoomNumber.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomNumber.ForeColor = System.Drawing.Color.Gray;
            this.TxtRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoomNumber.Location = new System.Drawing.Point(942, 120);
            this.TxtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRoomNumber.Name = "TxtRoomNumber";
            this.TxtRoomNumber.PasswordChar = '\0';
            this.TxtRoomNumber.PlaceholderText = "";
            this.TxtRoomNumber.SelectedText = "";
            this.TxtRoomNumber.Size = new System.Drawing.Size(311, 36);
            this.TxtRoomNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtRoomNumber.TabIndex = 8;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrice.DefaultText = "";
            this.TxtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.ForeColor = System.Drawing.Color.Gray;
            this.TxtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.Location = new System.Drawing.Point(941, 389);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.PlaceholderText = "";
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.Size = new System.Drawing.Size(312, 37);
            this.TxtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPrice.TabIndex = 9;
            // 
            // CmBoxRoomType
            // 
            this.CmBoxRoomType.BackColor = System.Drawing.Color.Transparent;
            this.CmBoxRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBoxRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmBoxRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmBoxRoomType.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxRoomType.ForeColor = System.Drawing.Color.Gray;
            this.CmBoxRoomType.ItemHeight = 30;
            this.CmBoxRoomType.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.CmBoxRoomType.Location = new System.Drawing.Point(941, 214);
            this.CmBoxRoomType.Name = "CmBoxRoomType";
            this.CmBoxRoomType.Size = new System.Drawing.Size(312, 36);
            this.CmBoxRoomType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CmBoxRoomType.TabIndex = 10;
            // 
            // CmBoxBed
            // 
            this.CmBoxBed.BackColor = System.Drawing.Color.Transparent;
            this.CmBoxBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmBoxBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBoxBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmBoxBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmBoxBed.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxBed.ForeColor = System.Drawing.Color.Gray;
            this.CmBoxBed.ItemHeight = 30;
            this.CmBoxBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.CmBoxBed.Location = new System.Drawing.Point(941, 298);
            this.CmBoxBed.Name = "CmBoxBed";
            this.CmBoxBed.Size = new System.Drawing.Size(312, 36);
            this.CmBoxBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CmBoxBed.TabIndex = 11;
            // 
            // BtnAddRoom
            // 
            this.BtnAddRoom.AutoRoundedCorners = true;
            this.BtnAddRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddRoom.BorderRadius = 25;
            this.BtnAddRoom.BorderThickness = 1;
            this.BtnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnAddRoom.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.BtnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddRoom.FillColor = System.Drawing.Color.White;
            this.BtnAddRoom.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddRoom.ForeColor = System.Drawing.Color.Black;
            this.BtnAddRoom.Location = new System.Drawing.Point(1009, 454);
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.Size = new System.Drawing.Size(170, 53);
            this.BtnAddRoom.TabIndex = 12;
            this.BtnAddRoom.Text = "Add Room";
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnAddRoom);
            this.Controls.Add(this.CmBoxBed);
            this.Controls.Add(this.CmBoxRoomType);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtRoomNumber);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelBed);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.DataGridView_2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.labelAddRoom);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(1464, 552);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddRoom;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_2;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelBed;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox TxtRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrice;
        private Guna.UI2.WinForms.Guna2ComboBox CmBoxRoomType;
        private Guna.UI2.WinForms.Guna2ComboBox CmBoxBed;
        private Guna.UI2.WinForms.Guna2Button BtnAddRoom;
    }
}
