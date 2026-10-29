namespace Foodcharge
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
            this.Food1 = new System.Windows.Forms.Label();
            this.Price1 = new System.Windows.Forms.Label();
            this.Food2 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.Label();
            this.txtFood1 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtFood2 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.outputlbl = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSalexText = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.salex = new System.Windows.Forms.Label();
            this.lbloutputofsum = new System.Windows.Forms.Label();
            this.outputlbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Food1
            // 
            this.Food1.AutoSize = true;
            this.Food1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food1.Location = new System.Drawing.Point(227, 41);
            this.Food1.Name = "Food1";
            this.Food1.Size = new System.Drawing.Size(217, 25);
            this.Food1.TabIndex = 0;
            this.Food1.Text = "Enter Name Food1   :\r\n";
            // 
            // Price1
            // 
            this.Price1.AutoSize = true;
            this.Price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price1.Location = new System.Drawing.Point(227, 91);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(210, 25);
            this.Price1.TabIndex = 0;
            this.Price1.Text = "Enter Price Food1   :\r\n";
            // 
            // Food2
            // 
            this.Food2.AutoSize = true;
            this.Food2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food2.Location = new System.Drawing.Point(227, 147);
            this.Food2.Name = "Food2";
            this.Food2.Size = new System.Drawing.Size(217, 25);
            this.Food2.TabIndex = 0;
            this.Food2.Text = "Enter Name Food2   :\r\n";
            // 
            // Price2
            // 
            this.Price2.AutoSize = true;
            this.Price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price2.Location = new System.Drawing.Point(227, 200);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(210, 25);
            this.Price2.TabIndex = 0;
            this.Price2.Text = "Enter Price Food2   :\r\n";
            // 
            // txtFood1
            // 
            this.txtFood1.Location = new System.Drawing.Point(523, 41);
            this.txtFood1.Multiline = true;
            this.txtFood1.Name = "txtFood1";
            this.txtFood1.Size = new System.Drawing.Size(317, 26);
            this.txtFood1.TabIndex = 1;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(523, 90);
            this.txtPrice1.Multiline = true;
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(317, 26);
            this.txtPrice1.TabIndex = 1;
            // 
            // txtFood2
            // 
            this.txtFood2.Location = new System.Drawing.Point(523, 146);
            this.txtFood2.Multiline = true;
            this.txtFood2.Name = "txtFood2";
            this.txtFood2.Size = new System.Drawing.Size(317, 26);
            this.txtFood2.TabIndex = 1;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(523, 201);
            this.txtPrice2.Multiline = true;
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(317, 26);
            this.txtPrice2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(373, 254);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 53);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate the price\r\n";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // outputlbl
            // 
            this.outputlbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputlbl.Controls.Add(this.lblTotalAmount);
            this.outputlbl.Controls.Add(this.lbloutputofsum);
            this.outputlbl.Controls.Add(this.lblSalexText);
            this.outputlbl.Controls.Add(this.Amount);
            this.outputlbl.Controls.Add(this.salex);
            this.outputlbl.Location = new System.Drawing.Point(232, 325);
            this.outputlbl.Name = "outputlbl";
            this.outputlbl.Size = new System.Drawing.Size(663, 190);
            this.outputlbl.TabIndex = 3;
            this.outputlbl.TabStop = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalAmount.Location = new System.Drawing.Point(317, 71);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(264, 29);
            this.lblTotalAmount.TabIndex = 1;
            // 
            // lblSalexText
            // 
            this.lblSalexText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalexText.Location = new System.Drawing.Point(317, 32);
            this.lblSalexText.Name = "lblSalexText";
            this.lblSalexText.Size = new System.Drawing.Size(264, 29);
            this.lblSalexText.TabIndex = 1;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Amount.Location = new System.Drawing.Point(28, 66);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(158, 27);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "Total Amount:";
            // 
            // salex
            // 
            this.salex.AutoSize = true;
            this.salex.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salex.Location = new System.Drawing.Point(28, 26);
            this.salex.Name = "salex";
            this.salex.Size = new System.Drawing.Size(151, 27);
            this.salex.TabIndex = 0;
            this.salex.Text = "Salex Text is :";
            // 
            // lbloutputofsum
            // 
            this.lbloutputofsum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbloutputofsum.Location = new System.Drawing.Point(126, 107);
            this.lbloutputofsum.Name = "lbloutputofsum";
            this.lbloutputofsum.Size = new System.Drawing.Size(332, 73);
            this.lbloutputofsum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 583);
            this.Controls.Add(this.outputlbl);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtFood2);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.txtFood1);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.Food2);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.Food1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.outputlbl.ResumeLayout(false);
            this.outputlbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Food1;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.Label Food2;
        private System.Windows.Forms.Label Price2;
        private System.Windows.Forms.TextBox txtFood1;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtFood2;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox outputlbl;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblSalexText;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label salex;
        private System.Windows.Forms.Label lbloutputofsum;
    }
}

