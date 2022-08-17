namespace Hotel_Project_380
{
    partial class Cart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.GroupBox();
            this.Totalprice = new System.Windows.Forms.Label();
            this.totalNights = new System.Windows.Forms.Label();
            this.totalNighttxt = new System.Windows.Forms.Label();
            this.totalGuest = new System.Windows.Forms.Label();
            this.leavedate = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.Label();
            this.roomDetails = new System.Windows.Forms.Label();
            this.roomKind = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.Label();
            this.checkIn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.zipcodetxt = new System.Windows.Forms.TextBox();
            this.statetxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cardtxt = new System.Windows.Forms.TextBox();
            this.cvvtxt = new System.Windows.Forms.TextBox();
            this.billingtxt = new System.Windows.Forms.TextBox();
            this.expirationtxt = new System.Windows.Forms.TextBox();
            this.Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(55, 87);
            this.firstName.Margin = new System.Windows.Forms.Padding(2);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(164, 25);
            this.firstName.TabIndex = 6;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(233, 87);
            this.lastName.Margin = new System.Windows.Forms.Padding(2);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(164, 25);
            this.lastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Credit Card Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "CVV";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Billing Zip Code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Expiration Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkOut
            // 
            this.checkOut.BackColor = System.Drawing.Color.White;
            this.checkOut.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(49, 415);
            this.checkOut.Margin = new System.Windows.Forms.Padding(2);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(217, 46);
            this.checkOut.TabIndex = 26;
            this.checkOut.Text = "Checkout";
            this.checkOut.UseVisualStyleBackColor = false;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Summary.Controls.Add(this.Totalprice);
            this.Summary.Controls.Add(this.totalNights);
            this.Summary.Controls.Add(this.totalNighttxt);
            this.Summary.Controls.Add(this.totalGuest);
            this.Summary.Controls.Add(this.leavedate);
            this.Summary.Controls.Add(this.startdate);
            this.Summary.Controls.Add(this.roomDetails);
            this.Summary.Controls.Add(this.roomKind);
            this.Summary.Controls.Add(this.Pricetxt);
            this.Summary.Controls.Add(this.checkOut);
            this.Summary.Controls.Add(this.label13);
            this.Summary.Controls.Add(this.pictureBox1);
            this.Summary.Controls.Add(this.endDate);
            this.Summary.Controls.Add(this.label8);
            this.Summary.Controls.Add(this.roomType);
            this.Summary.Controls.Add(this.checkIn);
            this.Summary.Dock = System.Windows.Forms.DockStyle.Right;
            this.Summary.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary.Location = new System.Drawing.Point(737, 0);
            this.Summary.Margin = new System.Windows.Forms.Padding(2);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(2);
            this.Summary.Size = new System.Drawing.Size(309, 500);
            this.Summary.TabIndex = 27;
            this.Summary.TabStop = false;
            this.Summary.Text = "Summary";
            // 
            // Totalprice
            // 
            this.Totalprice.AutoSize = true;
            this.Totalprice.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalprice.Location = new System.Drawing.Point(134, 365);
            this.Totalprice.Name = "Totalprice";
            this.Totalprice.Size = new System.Drawing.Size(38, 17);
            this.Totalprice.TabIndex = 43;
            this.Totalprice.Text = "null";
            this.Totalprice.Click += new System.EventHandler(this.Totalprice_Click);
            // 
            // totalNights
            // 
            this.totalNights.AutoSize = true;
            this.totalNights.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNights.Location = new System.Drawing.Point(134, 303);
            this.totalNights.Name = "totalNights";
            this.totalNights.Size = new System.Drawing.Size(38, 17);
            this.totalNights.TabIndex = 42;
            this.totalNights.Text = "null";
            // 
            // totalNighttxt
            // 
            this.totalNighttxt.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.totalNighttxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalNighttxt.AutoSize = true;
            this.totalNighttxt.BackColor = System.Drawing.Color.Transparent;
            this.totalNighttxt.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNighttxt.Location = new System.Drawing.Point(14, 303);
            this.totalNighttxt.Name = "totalNighttxt";
            this.totalNighttxt.Size = new System.Drawing.Size(114, 17);
            this.totalNighttxt.TabIndex = 41;
            this.totalNighttxt.Text = "Total Night(s):";
            this.totalNighttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalGuest
            // 
            this.totalGuest.AutoSize = true;
            this.totalGuest.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGuest.Location = new System.Drawing.Point(132, 272);
            this.totalGuest.Name = "totalGuest";
            this.totalGuest.Size = new System.Drawing.Size(38, 17);
            this.totalGuest.TabIndex = 40;
            this.totalGuest.Text = "null";
            // 
            // leavedate
            // 
            this.leavedate.AutoSize = true;
            this.leavedate.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leavedate.Location = new System.Drawing.Point(88, 243);
            this.leavedate.Name = "leavedate";
            this.leavedate.Size = new System.Drawing.Size(38, 17);
            this.leavedate.TabIndex = 39;
            this.leavedate.Text = "null";
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Location = new System.Drawing.Point(84, 213);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(38, 17);
            this.startdate.TabIndex = 38;
            this.startdate.Text = "null";
            // 
            // roomDetails
            // 
            this.roomDetails.AutoSize = true;
            this.roomDetails.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDetails.Location = new System.Drawing.Point(117, 166);
            this.roomDetails.Name = "roomDetails";
            this.roomDetails.Size = new System.Drawing.Size(38, 17);
            this.roomDetails.TabIndex = 37;
            this.roomDetails.Text = "null";
            // 
            // roomKind
            // 
            this.roomKind.AutoSize = true;
            this.roomKind.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomKind.Location = new System.Drawing.Point(64, 139);
            this.roomKind.Name = "roomKind";
            this.roomKind.Size = new System.Drawing.Size(38, 17);
            this.roomKind.TabIndex = 36;
            this.roomKind.Text = "null";
            this.roomKind.Click += new System.EventHandler(this.label16_Click);
            // 
            // Pricetxt
            // 
            this.Pricetxt.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Pricetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pricetxt.AutoSize = true;
            this.Pricetxt.BackColor = System.Drawing.Color.Transparent;
            this.Pricetxt.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricetxt.Location = new System.Drawing.Point(16, 365);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(124, 17);
            this.Pricetxt.TabIndex = 35;
            this.Pricetxt.Text = "Total for Stay: $";
            this.Pricetxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pricetxt.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Total Guest(s):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(14, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // endDate
            // 
            this.endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(14, 243);
            this.endDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(80, 17);
            this.endDate.TabIndex = 33;
            this.endDate.Tag = "endDate";
            this.endDate.Text = "Check Out:";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Room:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomType
            // 
            this.roomType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomType.AutoSize = true;
            this.roomType.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.Location = new System.Drawing.Point(14, 166);
            this.roomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(108, 17);
            this.roomType.TabIndex = 30;
            this.roomType.Tag = "roomTypeCart";
            this.roomType.Text = "Room Details:";
            this.roomType.Click += new System.EventHandler(this.roomType_Click);
            // 
            // checkIn
            // 
            this.checkIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIn.AutoSize = true;
            this.checkIn.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.Location = new System.Drawing.Point(14, 213);
            this.checkIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(73, 17);
            this.checkIn.TabIndex = 31;
            this.checkIn.Tag = "startDate";
            this.checkIn.Text = "Check In:";
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Address";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Zip Code";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(415, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "State";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(419, 87);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxt.Multiline = true;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(164, 25);
            this.emailtxt.TabIndex = 34;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(43, 158);
            this.addresstxt.Margin = new System.Windows.Forms.Padding(2);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(164, 25);
            this.addresstxt.TabIndex = 35;
            // 
            // zipcodetxt
            // 
            this.zipcodetxt.Location = new System.Drawing.Point(232, 158);
            this.zipcodetxt.Margin = new System.Windows.Forms.Padding(2);
            this.zipcodetxt.Multiline = true;
            this.zipcodetxt.Name = "zipcodetxt";
            this.zipcodetxt.Size = new System.Drawing.Size(164, 25);
            this.zipcodetxt.TabIndex = 36;
            // 
            // statetxt
            // 
            this.statetxt.Location = new System.Drawing.Point(419, 158);
            this.statetxt.Margin = new System.Windows.Forms.Padding(2);
            this.statetxt.Multiline = true;
            this.statetxt.Name = "statetxt";
            this.statetxt.Size = new System.Drawing.Size(54, 25);
            this.statetxt.TabIndex = 37;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(520, 158);
            this.phonetxt.Margin = new System.Windows.Forms.Padding(2);
            this.phonetxt.Multiline = true;
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(164, 25);
            this.phonetxt.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(516, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "Phone Number";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardtxt
            // 
            this.cardtxt.Location = new System.Drawing.Point(57, 255);
            this.cardtxt.Margin = new System.Windows.Forms.Padding(2);
            this.cardtxt.Multiline = true;
            this.cardtxt.Name = "cardtxt";
            this.cardtxt.Size = new System.Drawing.Size(164, 25);
            this.cardtxt.TabIndex = 40;
            // 
            // cvvtxt
            // 
            this.cvvtxt.Location = new System.Drawing.Point(343, 255);
            this.cvvtxt.Margin = new System.Windows.Forms.Padding(2);
            this.cvvtxt.Multiline = true;
            this.cvvtxt.Name = "cvvtxt";
            this.cvvtxt.Size = new System.Drawing.Size(164, 25);
            this.cvvtxt.TabIndex = 41;
            this.cvvtxt.TextChanged += new System.EventHandler(this.cvvtxt_TextChanged);
            // 
            // billingtxt
            // 
            this.billingtxt.Location = new System.Drawing.Point(43, 338);
            this.billingtxt.Margin = new System.Windows.Forms.Padding(2);
            this.billingtxt.Multiline = true;
            this.billingtxt.Name = "billingtxt";
            this.billingtxt.Size = new System.Drawing.Size(164, 25);
            this.billingtxt.TabIndex = 42;
            // 
            // expirationtxt
            // 
            this.expirationtxt.Location = new System.Drawing.Point(334, 338);
            this.expirationtxt.Margin = new System.Windows.Forms.Padding(2);
            this.expirationtxt.Multiline = true;
            this.expirationtxt.Name = "expirationtxt";
            this.expirationtxt.Size = new System.Drawing.Size(164, 25);
            this.expirationtxt.TabIndex = 43;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 500);
            this.Controls.Add(this.expirationtxt);
            this.Controls.Add(this.billingtxt);
            this.Controls.Add(this.cvvtxt);
            this.Controls.Add(this.cardtxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.statetxt);
            this.Controls.Add(this.zipcodetxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.Label Pricetxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label roomType;
        private System.Windows.Forms.Label checkIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox zipcodetxt;
        private System.Windows.Forms.TextBox statetxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cardtxt;
        private System.Windows.Forms.TextBox cvvtxt;
        private System.Windows.Forms.TextBox billingtxt;
        private System.Windows.Forms.TextBox expirationtxt;
        private System.Windows.Forms.Label roomKind;
        private System.Windows.Forms.Label roomDetails;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label leavedate;
        private System.Windows.Forms.Label totalGuest;
        private System.Windows.Forms.Label totalNighttxt;
        private System.Windows.Forms.Label totalNights;
        private System.Windows.Forms.Label Totalprice;
    }
}