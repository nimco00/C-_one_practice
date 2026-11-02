namespace BMI_weight
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
            this.weightlbl = new System.Windows.Forms.Label();
            this.Heightlbl = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.listoutput = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightlbl
            // 
            this.weightlbl.AutoSize = true;
            this.weightlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightlbl.Location = new System.Drawing.Point(57, 46);
            this.weightlbl.Name = "weightlbl";
            this.weightlbl.Size = new System.Drawing.Size(194, 20);
            this.weightlbl.TabIndex = 0;
            this.weightlbl.Text = "Weight in kilogram (Kg)";
            // 
            // Heightlbl
            // 
            this.Heightlbl.AutoSize = true;
            this.Heightlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightlbl.Location = new System.Drawing.Point(57, 92);
            this.Heightlbl.Name = "Heightlbl";
            this.Heightlbl.Size = new System.Drawing.Size(163, 20);
            this.Heightlbl.TabIndex = 0;
            this.Heightlbl.Text = "Height in Meter (M)";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(428, 46);
            this.txtweight.Multiline = true;
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(238, 26);
            this.txtweight.TabIndex = 1;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(428, 92);
            this.txtheight.Multiline = true;
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(238, 26);
            this.txtheight.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(61, 177);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(155, 77);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Calculated Bmi";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // listoutput
            // 
            this.listoutput.FormattingEnabled = true;
            this.listoutput.ItemHeight = 20;
            this.listoutput.Location = new System.Drawing.Point(722, 67);
            this.listoutput.Name = "listoutput";
            this.listoutput.Size = new System.Drawing.Size(191, 224);
            this.listoutput.TabIndex = 5;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(301, 177);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(167, 77);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 77);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1014, 524);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.listoutput);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.Heightlbl);
            this.Controls.Add(this.weightlbl);
            this.Name = "Form1";
            this.Text = "BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightlbl;
        private System.Windows.Forms.Label Heightlbl;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ListBox listoutput;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
    }
}

