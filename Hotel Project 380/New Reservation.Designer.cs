namespace Hotel_Project_380
{
    partial class New_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Reservation));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Checkout_calender = new System.Windows.Forms.DateTimePicker();
            this.CheckIn_calender = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Guest = new System.Windows.Forms.Label();
            this.guestnum = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.roomType = new System.Windows.Forms.GroupBox();
            this.radiobtnPres = new System.Windows.Forms.RadioButton();
            this.radioBtnPentHouse = new System.Windows.Forms.RadioButton();
            this.radioBtnSuite = new System.Windows.Forms.RadioButton();
            this.radioBtnStudio = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(40, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Check Out Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(40, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Check In Date:";
            // 
            // Checkout_calender
            // 
            this.Checkout_calender.Location = new System.Drawing.Point(247, 418);
            this.Checkout_calender.MinDate = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            this.Checkout_calender.Name = "Checkout_calender";
            this.Checkout_calender.Size = new System.Drawing.Size(200, 20);
            this.Checkout_calender.TabIndex = 10;
            // 
            // CheckIn_calender
            // 
            this.CheckIn_calender.Location = new System.Drawing.Point(231, 330);
            this.CheckIn_calender.MinDate = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            this.CheckIn_calender.Name = "CheckIn_calender";
            this.CheckIn_calender.Size = new System.Drawing.Size(200, 20);
            this.CheckIn_calender.TabIndex = 9;
            this.CheckIn_calender.Value = new System.DateTime(2022, 8, 15, 16, 48, 49, 0);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.Guest);
            this.panel3.Controls.Add(this.guestnum);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Checkout_calender);
            this.panel3.Controls.Add(this.CheckIn_calender);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 690);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Guest
            // 
            this.Guest.AutoSize = true;
            this.Guest.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest.ForeColor = System.Drawing.Color.Teal;
            this.Guest.Location = new System.Drawing.Point(40, 191);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(149, 34);
            this.Guest.TabIndex = 15;
            this.Guest.Text = "Total Guest:";
            // 
            // guestnum
            // 
            this.guestnum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestnum.FormattingEnabled = true;
            this.guestnum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.guestnum.Location = new System.Drawing.Point(195, 200);
            this.guestnum.Name = "guestnum";
            this.guestnum.Size = new System.Drawing.Size(121, 23);
            this.guestnum.TabIndex = 14;
            this.guestnum.SelectedIndexChanged += new System.EventHandler(this.guestnum_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(478, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 90);
            this.panel1.TabIndex = 17;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(716, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(194, 90);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Book Now!";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // roomType
            // 
            this.roomType.Controls.Add(this.radiobtnPres);
            this.roomType.Controls.Add(this.radioBtnPentHouse);
            this.roomType.Controls.Add(this.radioBtnSuite);
            this.roomType.Controls.Add(this.radioBtnStudio);
            this.roomType.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomType.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.ForeColor = System.Drawing.Color.Teal;
            this.roomType.Location = new System.Drawing.Point(478, 0);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(910, 510);
            this.roomType.TabIndex = 18;
            this.roomType.TabStop = false;
            this.roomType.Text = "Check Out Our Rooms!";
            this.roomType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radiobtnPres
            // 
            this.radiobtnPres.AutoSize = true;
            this.radiobtnPres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobtnPres.Dock = System.Windows.Forms.DockStyle.Top;
            this.radiobtnPres.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnPres.ForeColor = System.Drawing.Color.Teal;
            this.radiobtnPres.Image = ((System.Drawing.Image)(resources.GetObject("radiobtnPres.Image")));
            this.radiobtnPres.Location = new System.Drawing.Point(3, 396);
            this.radiobtnPres.Name = "radiobtnPres";
            this.radiobtnPres.Size = new System.Drawing.Size(904, 121);
            this.radiobtnPres.TabIndex = 23;
            this.radiobtnPres.TabStop = true;
            this.radiobtnPres.Text = "Three Bedroom Presidential Suite  \r\n3 King Beds\r\nMax Guests 6\r\n$5000.00 avg/night" +
    "";
            this.radiobtnPres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnPres.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radiobtnPres.UseVisualStyleBackColor = true;
            // 
            // radioBtnPentHouse
            // 
            this.radioBtnPentHouse.AutoSize = true;
            this.radioBtnPentHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnPentHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBtnPentHouse.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPentHouse.ForeColor = System.Drawing.Color.Teal;
            this.radioBtnPentHouse.Image = ((System.Drawing.Image)(resources.GetObject("radioBtnPentHouse.Image")));
            this.radioBtnPentHouse.Location = new System.Drawing.Point(3, 288);
            this.radioBtnPentHouse.Name = "radioBtnPentHouse";
            this.radioBtnPentHouse.Size = new System.Drawing.Size(904, 108);
            this.radioBtnPentHouse.TabIndex = 22;
            this.radioBtnPentHouse.TabStop = true;
            this.radioBtnPentHouse.Text = "Two Bedroom Penthouse Sky View   \r\n2 King Beds\r\nMax Guests 4\r\n$2000.00 avg/night";
            this.radioBtnPentHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnPentHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioBtnPentHouse.UseVisualStyleBackColor = true;
            // 
            // radioBtnSuite
            // 
            this.radioBtnSuite.AutoSize = true;
            this.radioBtnSuite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnSuite.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBtnSuite.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSuite.ForeColor = System.Drawing.Color.Teal;
            this.radioBtnSuite.Image = ((System.Drawing.Image)(resources.GetObject("radioBtnSuite.Image")));
            this.radioBtnSuite.Location = new System.Drawing.Point(3, 157);
            this.radioBtnSuite.Name = "radioBtnSuite";
            this.radioBtnSuite.Size = new System.Drawing.Size(904, 131);
            this.radioBtnSuite.TabIndex = 21;
            this.radioBtnSuite.TabStop = true;
            this.radioBtnSuite.Text = "One Bedroom Panoramic View Suite\r\n1 King Bed/ 2 Queen Beds\r\nMax Guests 4\r\n$1000.0" +
    "0 avg/night";
            this.radioBtnSuite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnSuite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioBtnSuite.UseVisualStyleBackColor = true;
            // 
            // radioBtnStudio
            // 
            this.radioBtnStudio.AutoSize = true;
            this.radioBtnStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBtnStudio.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnStudio.ForeColor = System.Drawing.Color.Teal;
            this.radioBtnStudio.Image = ((System.Drawing.Image)(resources.GetObject("radioBtnStudio.Image")));
            this.radioBtnStudio.Location = new System.Drawing.Point(3, 40);
            this.radioBtnStudio.Name = "radioBtnStudio";
            this.radioBtnStudio.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.radioBtnStudio.Size = new System.Drawing.Size(904, 117);
            this.radioBtnStudio.TabIndex = 20;
            this.radioBtnStudio.TabStop = true;
            this.radioBtnStudio.Text = "Studio Deluxe Room\r\n1 king Bed/ 2 Queen Beds          \r\nMax Guests 4\r\n$500.00 avg" +
    "/night";
            this.radioBtnStudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioBtnStudio.UseVisualStyleBackColor = true;
            this.radioBtnStudio.CheckedChanged += new System.EventHandler(this.radioBtnStudio_CheckedChanged);
            // 
            // New_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1388, 690);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Reservation";
            this.Load += new System.EventHandler(this.New_Reservation_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.roomType.ResumeLayout(false);
            this.roomType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Checkout_calender;
        private System.Windows.Forms.DateTimePicker CheckIn_calender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox roomType;
        private System.Windows.Forms.RadioButton radioBtnStudio;
        private System.Windows.Forms.RadioButton radioBtnSuite;
        private System.Windows.Forms.RadioButton radioBtnPentHouse;
        private System.Windows.Forms.RadioButton radiobtnPres;
        private System.Windows.Forms.ComboBox guestnum;
        private System.Windows.Forms.Label Guest;
    }
}