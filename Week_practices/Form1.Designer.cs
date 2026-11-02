namespace Week_practices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dayofweeklbl = new System.Windows.Forms.Label();
            this.monthlbl = new System.Windows.Forms.Label();
            this.yearlbl = new System.Windows.Forms.Label();
            this.Dayofthemonthlbl = new System.Windows.Forms.Label();
            this.textdayweek = new System.Windows.Forms.TextBox();
            this.textmonth = new System.Windows.Forms.TextBox();
            this.textdaymonth = new System.Windows.Forms.TextBox();
            this.textyear = new System.Windows.Forms.TextBox();
            this.textfulldata = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dayofweeklbl
            // 
            this.Dayofweeklbl.AutoSize = true;
            this.Dayofweeklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Dayofweeklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dayofweeklbl.Location = new System.Drawing.Point(152, 60);
            this.Dayofweeklbl.Name = "Dayofweeklbl";
            this.Dayofweeklbl.Size = new System.Drawing.Size(173, 50);
            this.Dayofweeklbl.TabIndex = 0;
            this.Dayofweeklbl.Text = "Day of the week:\r\n\r\n";
            // 
            // monthlbl
            // 
            this.monthlbl.AutoSize = true;
            this.monthlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.monthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlbl.Location = new System.Drawing.Point(152, 99);
            this.monthlbl.Name = "monthlbl";
            this.monthlbl.Size = new System.Drawing.Size(79, 75);
            this.monthlbl.TabIndex = 0;
            this.monthlbl.Text = "Month:\r\n\r\n\r\n";
            // 
            // yearlbl
            // 
            this.yearlbl.AutoSize = true;
            this.yearlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.yearlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlbl.Location = new System.Drawing.Point(152, 200);
            this.yearlbl.Name = "yearlbl";
            this.yearlbl.Size = new System.Drawing.Size(54, 50);
            this.yearlbl.TabIndex = 0;
            this.yearlbl.Text = "year\r\n\r\n";
            this.yearlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dayofthemonthlbl
            // 
            this.Dayofthemonthlbl.AutoSize = true;
            this.Dayofthemonthlbl.BackColor = System.Drawing.Color.Silver;
            this.Dayofthemonthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dayofthemonthlbl.Location = new System.Drawing.Point(146, 143);
            this.Dayofthemonthlbl.Name = "Dayofthemonthlbl";
            this.Dayofthemonthlbl.Size = new System.Drawing.Size(168, 66);
            this.Dayofthemonthlbl.TabIndex = 0;
            this.Dayofthemonthlbl.Text = "Day of the month:\r\n\r\n\r\n";
            this.Dayofthemonthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textdayweek
            // 
            this.textdayweek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textdayweek.Location = new System.Drawing.Point(373, 60);
            this.textdayweek.Multiline = true;
            this.textdayweek.Name = "textdayweek";
            this.textdayweek.Size = new System.Drawing.Size(209, 31);
            this.textdayweek.TabIndex = 1;
            // 
            // textmonth
            // 
            this.textmonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textmonth.Location = new System.Drawing.Point(373, 98);
            this.textmonth.Multiline = true;
            this.textmonth.Name = "textmonth";
            this.textmonth.Size = new System.Drawing.Size(209, 31);
            this.textmonth.TabIndex = 1;
            // 
            // textdaymonth
            // 
            this.textdaymonth.BackColor = System.Drawing.Color.Silver;
            this.textdaymonth.Location = new System.Drawing.Point(373, 135);
            this.textdaymonth.Multiline = true;
            this.textdaymonth.Name = "textdaymonth";
            this.textdaymonth.Size = new System.Drawing.Size(209, 31);
            this.textdaymonth.TabIndex = 1;
            // 
            // textyear
            // 
            this.textyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textyear.Location = new System.Drawing.Point(373, 191);
            this.textyear.Multiline = true;
            this.textyear.Name = "textyear";
            this.textyear.Size = new System.Drawing.Size(209, 31);
            this.textyear.TabIndex = 1;
            // 
            // textfulldata
            // 
            this.textfulldata.BackColor = System.Drawing.Color.Fuchsia;
            this.textfulldata.Location = new System.Drawing.Point(157, 254);
            this.textfulldata.Multiline = true;
            this.textfulldata.Name = "textfulldata";
            this.textfulldata.Size = new System.Drawing.Size(425, 55);
            this.textfulldata.TabIndex = 2;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Red;
            this.btnshow.Location = new System.Drawing.Point(157, 341);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(115, 38);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "show data";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnclear.Location = new System.Drawing.Point(278, 341);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(103, 38);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Blue;
            this.btnexit.Location = new System.Drawing.Point(411, 341);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 38);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.textfulldata);
            this.Controls.Add(this.textyear);
            this.Controls.Add(this.textdaymonth);
            this.Controls.Add(this.textmonth);
            this.Controls.Add(this.textdayweek);
            this.Controls.Add(this.Dayofthemonthlbl);
            this.Controls.Add(this.yearlbl);
            this.Controls.Add(this.monthlbl);
            this.Controls.Add(this.Dayofweeklbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dayofweeklbl;
        private System.Windows.Forms.Label monthlbl;
        private System.Windows.Forms.Label yearlbl;
        private System.Windows.Forms.Label Dayofthemonthlbl;
        private System.Windows.Forms.TextBox textdayweek;
        private System.Windows.Forms.TextBox textmonth;
        private System.Windows.Forms.TextBox textdaymonth;
        private System.Windows.Forms.TextBox textyear;
        private System.Windows.Forms.TextBox textfulldata;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

