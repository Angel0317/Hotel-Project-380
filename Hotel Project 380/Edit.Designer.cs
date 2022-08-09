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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkintb = new System.Windows.Forms.DateTimePicker();
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
            this.reservationidtb.Location = new System.Drawing.Point(271, 146);
            this.reservationidtb.Multiline = true;
            this.reservationidtb.Name = "reservationidtb";
            this.reservationidtb.Size = new System.Drawing.Size(272, 36);
            this.reservationidtb.TabIndex = 1;
            this.reservationidtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.lastnametb.Location = new System.Drawing.Point(271, 266);
            this.lastnametb.Multiline = true;
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(272, 36);
            this.lastnametb.TabIndex = 4;
            this.lastnametb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // firstnametb
            // 
            this.firstnametb.Location = new System.Drawing.Point(271, 206);
            this.firstnametb.Multiline = true;
            this.firstnametb.Name = "firstnametb";
            this.firstnametb.Size = new System.Drawing.Size(272, 36);
            this.firstnametb.TabIndex = 5;
            this.firstnametb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Reservationtb
            // 
            this.Reservationtb.Location = new System.Drawing.Point(271, 401);
            this.Reservationtb.Name = "Reservationtb";
            this.Reservationtb.Size = new System.Drawing.Size(93, 40);
            this.Reservationtb.TabIndex = 6;
            this.Reservationtb.Text = "Lookup";
            this.Reservationtb.UseVisualStyleBackColor = true;
            this.Reservationtb.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(614, 145);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(619, 546);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(614, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancel Reservation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Check In Date:";
            // 
            // checkintb
            // 
            this.checkintb.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkintb.Location = new System.Drawing.Point(271, 333);
            this.checkintb.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.checkintb.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.checkintb.Name = "checkintb";
            this.checkintb.Size = new System.Drawing.Size(272, 40);
            this.checkintb.TabIndex = 11;
            this.checkintb.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1464, 692);
            this.Controls.Add(this.checkintb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkedListBox1);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker checkintb;
    }
}