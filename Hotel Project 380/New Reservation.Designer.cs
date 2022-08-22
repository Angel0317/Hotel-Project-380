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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Label();
            this.guestnum = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bookNow = new FontAwesome.Sharp.IconButton();
            this.roomType = new System.Windows.Forms.GroupBox();
            this.radiobtnPres = new System.Windows.Forms.RadioButton();
            this.radioBtnPentHouse = new System.Windows.Forms.RadioButton();
            this.radioBtnSuite = new System.Windows.Forms.RadioButton();
            this.radioBtnStudio = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.roomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(296, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Check Out";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(63, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Check In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Checkout_calender
            // 
            this.Checkout_calender.Location = new System.Drawing.Point(260, 379);
            this.Checkout_calender.MinDate = new System.DateTime(2022, 8, 22, 0, 0, 0, 0);
            this.Checkout_calender.Name = "Checkout_calender";
            this.Checkout_calender.Size = new System.Drawing.Size(200, 20);
            this.Checkout_calender.TabIndex = 10;
            this.Checkout_calender.Value = new System.DateTime(2022, 8, 22, 0, 0, 0, 0);
            this.Checkout_calender.ValueChanged += new System.EventHandler(this.Checkout_calender_ValueChanged);
            // 
            // CheckIn_calender
            // 
            this.CheckIn_calender.Location = new System.Drawing.Point(21, 379);
            this.CheckIn_calender.MinDate = new System.DateTime(2022, 8, 22, 0, 0, 0, 0);
            this.CheckIn_calender.Name = "CheckIn_calender";
            this.CheckIn_calender.Size = new System.Drawing.Size(200, 20);
            this.CheckIn_calender.TabIndex = 9;
            this.CheckIn_calender.Value = new System.DateTime(2022, 8, 22, 0, 0, 0, 0);
            this.CheckIn_calender.ValueChanged += new System.EventHandler(this.CheckIn_calender_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Guest);
            this.panel3.Controls.Add(this.guestnum);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Checkout_calender);
            this.panel3.Controls.Add(this.CheckIn_calender);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 696);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(47, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "Book Your Escape Today.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guest
            // 
            this.Guest.AutoSize = true;
            this.Guest.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest.ForeColor = System.Drawing.Color.Teal;
            this.Guest.Location = new System.Drawing.Point(15, 465);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(185, 34);
            this.Guest.TabIndex = 15;
            this.Guest.Text = "Total Guest(s) :";
            this.Guest.Click += new System.EventHandler(this.Guest_Click);
            // 
            // guestnum
            // 
            this.guestnum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestnum.FormattingEnabled = true;
            this.guestnum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.guestnum.Location = new System.Drawing.Point(206, 474);
            this.guestnum.Name = "guestnum";
            this.guestnum.Size = new System.Drawing.Size(203, 23);
            this.guestnum.TabIndex = 14;
            this.guestnum.SelectedIndexChanged += new System.EventHandler(this.guestnum_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bookNow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(478, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 90);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stay Up, stay shiny, and get your rest on!";
            // 
            // bookNow
            // 
            this.bookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookNow.Dock = System.Windows.Forms.DockStyle.Right;
            this.bookNow.FlatAppearance.BorderSize = 0;
            this.bookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookNow.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookNow.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.bookNow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookNow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookNow.Location = new System.Drawing.Point(877, 0);
            this.bookNow.Name = "bookNow";
            this.bookNow.Size = new System.Drawing.Size(194, 90);
            this.bookNow.TabIndex = 0;
            this.bookNow.Text = "Book Now!";
            this.bookNow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookNow.UseVisualStyleBackColor = true;
            this.bookNow.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.roomType.Size = new System.Drawing.Size(1071, 510);
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
            this.radiobtnPres.Size = new System.Drawing.Size(1065, 121);
            this.radiobtnPres.TabIndex = 23;
            this.radiobtnPres.Text = "Three Bedroom Presidential Suite  \r\n3 King Beds\r\nMax Guests 4\r\n$5000.00 avg/night" +
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
            this.radioBtnPentHouse.Size = new System.Drawing.Size(1065, 108);
            this.radioBtnPentHouse.TabIndex = 22;
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
            this.radioBtnSuite.Size = new System.Drawing.Size(1065, 131);
            this.radioBtnSuite.TabIndex = 21;
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
            this.radioBtnStudio.Size = new System.Drawing.Size(1065, 117);
            this.radioBtnStudio.TabIndex = 20;
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
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1549, 696);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private FontAwesome.Sharp.IconButton bookNow;
        private System.Windows.Forms.GroupBox roomType;
        private System.Windows.Forms.RadioButton radioBtnStudio;
        private System.Windows.Forms.RadioButton radioBtnSuite;
        private System.Windows.Forms.RadioButton radioBtnPentHouse;
        private System.Windows.Forms.RadioButton radiobtnPres;
        private System.Windows.Forms.ComboBox guestnum;
        private System.Windows.Forms.Label Guest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}