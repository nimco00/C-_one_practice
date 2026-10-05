namespace Payroll_with_Overtime
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
            this.lblHoursworked = new System.Windows.Forms.Label();
            this.lblHourlyPayRate = new System.Windows.Forms.Label();
            this.lblGrosspay = new System.Windows.Forms.Label();
            this.txthoursworked = new System.Windows.Forms.TextBox();
            this.txthourlyrate = new System.Windows.Forms.TextBox();
            this.grosspaylbl = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoursworked
            // 
            this.lblHoursworked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursworked.Location = new System.Drawing.Point(214, 60);
            this.lblHoursworked.Name = "lblHoursworked";
            this.lblHoursworked.Size = new System.Drawing.Size(201, 31);
            this.lblHoursworked.TabIndex = 0;
            this.lblHoursworked.Text = "Hours Worked:";
            // 
            // lblHourlyPayRate
            // 
            this.lblHourlyPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyPayRate.Location = new System.Drawing.Point(214, 109);
            this.lblHourlyPayRate.Name = "lblHourlyPayRate";
            this.lblHourlyPayRate.Size = new System.Drawing.Size(201, 31);
            this.lblHourlyPayRate.TabIndex = 0;
            this.lblHourlyPayRate.Text = "Hourly Pay rate:";
            // 
            // lblGrosspay
            // 
            this.lblGrosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrosspay.Location = new System.Drawing.Point(264, 160);
            this.lblGrosspay.Name = "lblGrosspay";
            this.lblGrosspay.Size = new System.Drawing.Size(164, 31);
            this.lblGrosspay.TabIndex = 0;
            this.lblGrosspay.Text = "Gross Pay:";
            // 
            // txthoursworked
            // 
            this.txthoursworked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoursworked.Location = new System.Drawing.Point(500, 56);
            this.txthoursworked.Multiline = true;
            this.txthoursworked.Name = "txthoursworked";
            this.txthoursworked.Size = new System.Drawing.Size(278, 39);
            this.txthoursworked.TabIndex = 1;
            // 
            // txthourlyrate
            // 
            this.txthourlyrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthourlyrate.Location = new System.Drawing.Point(500, 106);
            this.txthourlyrate.Multiline = true;
            this.txthourlyrate.Name = "txthourlyrate";
            this.txthourlyrate.Size = new System.Drawing.Size(278, 39);
            this.txthourlyrate.TabIndex = 1;
            // 
            // grosspaylbl
            // 
            this.grosspaylbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grosspaylbl.Location = new System.Drawing.Point(500, 170);
            this.grosspaylbl.Name = "grosspaylbl";
            this.grosspaylbl.Size = new System.Drawing.Size(286, 35);
            this.grosspaylbl.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(235, 271);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 67);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate \r\nGross Pay";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(401, 274);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(182, 61);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear\r\n";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(604, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 572);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grosspaylbl);
            this.Controls.Add(this.txthourlyrate);
            this.Controls.Add(this.txthoursworked);
            this.Controls.Add(this.lblGrosspay);
            this.Controls.Add(this.lblHourlyPayRate);
            this.Controls.Add(this.lblHoursworked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoursworked;
        private System.Windows.Forms.Label lblHourlyPayRate;
        private System.Windows.Forms.Label lblGrosspay;
        private System.Windows.Forms.TextBox txthoursworked;
        private System.Windows.Forms.TextBox txthourlyrate;
        private System.Windows.Forms.Label grosspaylbl;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
    }
}

