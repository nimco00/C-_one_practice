using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assigment_Ca242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowday_Click(object sender, EventArgs e)
        {
            //stage 1 of input
            //creating variable

            string Dayof_week, name_of_month, FuLl_Date;
            int numeric_day;
            int year;

            //initial values to variable
            Dayof_week = txtdayoftheweek.Text;
            name_of_month =txtdayofmonth.Text;
            numeric_day = int.Parse(txtdayofthenumeric.Text);
            year = int.Parse(txtyear.Text);

            // stage 2 process -concatination of full date
            FuLl_Date = Dayof_week + "," + name_of_month + "," + numeric_day + "," + year;

            //stage 3  output using lable
            lbloutput.Text = FuLl_Date;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox and label


            txtdayoftheweek.Clear();
            txtdayofmonth.Text = "";
            txtdayofthenumeric.Text= string.Empty;
            txtyear.Clear();
            lbloutput.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //form close - using this keyword and close function

            this.Close();
        }
    }
}
