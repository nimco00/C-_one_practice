namespace Software_sles
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
            this.Numerlbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.listresult = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numerlbl
            // 
            this.Numerlbl.AutoSize = true;
            this.Numerlbl.Location = new System.Drawing.Point(34, 32);
            this.Numerlbl.Name = "Numerlbl";
            this.Numerlbl.Size = new System.Drawing.Size(148, 20);
            this.Numerlbl.TabIndex = 0;
            this.Numerlbl.Text = "Number of package";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(34, 87);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(127, 20);
            this.pricelbl.TabIndex = 0;
            this.pricelbl.Text = "Price of package";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(330, 32);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(208, 31);
            this.txtNumber.TabIndex = 1;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(330, 76);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(208, 31);
            this.txtprice.TabIndex = 1;
            // 
            // listresult
            // 
            this.listresult.FormattingEnabled = true;
            this.listresult.ItemHeight = 20;
            this.listresult.Location = new System.Drawing.Point(649, 12);
            this.listresult.Name = "listresult";
            this.listresult.Size = new System.Drawing.Size(396, 344);
            this.listresult.TabIndex = 2;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(12, 151);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(127, 67);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(176, 151);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 67);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(352, 164);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(127, 67);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 586);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listresult);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.Numerlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numerlbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.ListBox listresult;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

