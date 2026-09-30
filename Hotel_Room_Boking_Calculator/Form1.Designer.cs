namespace Hotel_Room_Boking_Calculator
{
    partial class Form1
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
            this.GuestName = new System.Windows.Forms.Label();
            this.lblroom = new System.Windows.Forms.Label();
            this.Numbernight = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.GroupBox();
            this.Total = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbloutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuestName
            // 
            this.GuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestName.Location = new System.Drawing.Point(288, 115);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(294, 29);
            this.GuestName.TabIndex = 0;
            this.GuestName.Text = "Enter Guest Name             :\r\n\r\n";
            // 
            // lblroom
            // 
            this.lblroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroom.Location = new System.Drawing.Point(288, 147);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(328, 34);
            this.lblroom.TabIndex = 0;
            this.lblroom.Text = "Enter Room Type               :\r\n";
            // 
            // Numbernight
            // 
            this.Numbernight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numbernight.Location = new System.Drawing.Point(288, 181);
            this.Numbernight.Name = "Numbernight";
            this.Numbernight.Size = new System.Drawing.Size(328, 31);
            this.Numbernight.TabIndex = 0;
            this.Numbernight.Text = "Enter Number of Night        :";
            // 
            // lblprice
            // 
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(288, 221);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(294, 42);
            this.lblprice.TabIndex = 0;
            this.lblprice.Text = "Enter Price Per Night            :";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(621, 115);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(423, 29);
            this.txtGuestName.TabIndex = 1;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(621, 148);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(423, 29);
            this.txtRoomType.TabIndex = 1;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(621, 181);
            this.txtNights.Multiline = true;
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(423, 29);
            this.txtNights.TabIndex = 1;
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Location = new System.Drawing.Point(621, 221);
            this.txtPriceNight.Multiline = true;
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(423, 29);
            this.txtPriceNight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.BackColor = System.Drawing.Color.Blue;
            this.btnCalculate.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(482, 290);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(296, 50);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Booking";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(292, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(692, 58);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Hotel Booking Calculator\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbloutput.Controls.Add(this.lblTotalAmount);
            this.lbloutput.Controls.Add(this.lblDiscount);
            this.lbloutput.Controls.Add(this.lblServiceTax);
            this.lbloutput.Controls.Add(this.Total);
            this.lbloutput.Controls.Add(this.Discount);
            this.lbloutput.Controls.Add(this.service);
            this.lbloutput.Location = new System.Drawing.Point(269, 352);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(792, 161);
            this.lbloutput.TabIndex = 6;
            this.lbloutput.TabStop = false;
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(21, 101);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(322, 32);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total Amount                         :\r\n";
            // 
            // Discount
            // 
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(21, 65);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(322, 32);
            this.Discount.TabIndex = 7;
            this.Discount.Text = "Discount(5%)                         :";
            // 
            // service
            // 
            this.service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(21, 29);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(322, 42);
            this.service.TabIndex = 8;
            this.service.Text = "Service Tax (10%)                   :";
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.BackColor = System.Drawing.Color.White;
            this.lblServiceTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceTax.Location = new System.Drawing.Point(394, 29);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(321, 31);
            this.lblServiceTax.TabIndex = 9;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.White;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(394, 66);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(321, 31);
            this.lblDiscount.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Location = new System.Drawing.Point(394, 105);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(321, 31);
            this.lblTotalAmount.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1460, 681);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.Numbernight);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.GuestName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lbloutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuestName;
        private System.Windows.Forms.Label lblroom;
        private System.Windows.Forms.Label Numbernight;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox lbloutput;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblServiceTax;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

