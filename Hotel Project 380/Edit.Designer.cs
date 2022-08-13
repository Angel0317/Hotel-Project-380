namespace Hotel_Project_380
{
    partial class Edit
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
            this.reservationidtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnametb = new System.Windows.Forms.TextBox();
            this.firstnametb = new System.Windows.Forms.TextBox();
            this.Reservationtb = new System.Windows.Forms.Button();
            this.cancelReservationtb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkintb = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ReservationDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reservationidtb
            // 
            this.reservationidtb.Location = new System.Drawing.Point(290, 154);
            this.reservationidtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reservationidtb.Name = "reservationidtb";
            this.reservationidtb.Size = new System.Drawing.Size(272, 26);
            this.reservationidtb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // lastnametb
            // 
            this.lastnametb.Location = new System.Drawing.Point(290, 274);
            this.lastnametb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(272, 26);
            this.lastnametb.TabIndex = 13;
            // 
            // firstnametb
            // 
            this.firstnametb.Location = new System.Drawing.Point(290, 214);
            this.firstnametb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstnametb.Name = "firstnametb";
            this.firstnametb.Size = new System.Drawing.Size(272, 26);
            this.firstnametb.TabIndex = 12;
            // 
            // Reservationtb
            // 
            this.Reservationtb.Location = new System.Drawing.Point(272, 402);
            this.Reservationtb.Name = "Reservationtb";
            this.Reservationtb.Size = new System.Drawing.Size(134, 40);
            this.Reservationtb.TabIndex = 6;
            this.Reservationtb.Text = "Lookup";
            this.Reservationtb.UseVisualStyleBackColor = true;
            this.Reservationtb.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelReservationtb
            // 
            this.cancelReservationtb.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelReservationtb.Location = new System.Drawing.Point(614, 95);
            this.cancelReservationtb.Name = "cancelReservationtb";
            this.cancelReservationtb.Size = new System.Drawing.Size(256, 45);
            this.cancelReservationtb.TabIndex = 9;
            this.cancelReservationtb.Text = "Cancel Reservation";
            this.cancelReservationtb.UseVisualStyleBackColor = true;
            this.cancelReservationtb.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Check In Date:";
            // 
            // checkintb
            // 
            this.checkintb.Location = new System.Drawing.Point(0, 0);
            this.checkintb.Name = "checkintb";
            this.checkintb.Size = new System.Drawing.Size(200, 26);
            this.checkintb.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 334);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // ReservationDisplay
            // 
            this.ReservationDisplay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReservationDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationDisplay.GridColor = System.Drawing.Color.White;
            this.ReservationDisplay.Location = new System.Drawing.Point(614, 154);
            this.ReservationDisplay.Name = "ReservationDisplay";
            this.ReservationDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ReservationDisplay.RowTemplate.Height = 28;
            this.ReservationDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationDisplay.Size = new System.Drawing.Size(836, 288);
            this.ReservationDisplay.TabIndex = 16;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1946, 983);
            this.Controls.Add(this.ReservationDisplay);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelReservationtb);
            this.Controls.Add(this.Reservationtb);
            this.Controls.Add(this.firstnametb);
            this.Controls.Add(this.lastnametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reservationidtb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reservationidtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastnametb;
        private System.Windows.Forms.TextBox firstnametb;
        private System.Windows.Forms.Button Reservationtb;
        private System.Windows.Forms.Button cancelReservationtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker checkintb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView ReservationDisplay;
    }
}