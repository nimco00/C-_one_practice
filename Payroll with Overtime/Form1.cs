using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variable
                double hoursworked;
                double hourlypayrate;

                // Convert TextBox values to double
                hoursworked = Convert.ToDouble(txthoursworked.Text);
                hourlypayrate = Convert.ToDouble(txthourlyrate.Text);

                //check if hours worked are valid
                if (hoursworked >= 0)
                {
                    //check if hourly pay rate is valid
                    if (hourlypayrate >= 0)
                    {
                        double grosspay;

                        // check if the employee worked overtime 
                        if (hoursworked <= 40)
                        {
                            //Regular pay 
                            grosspay = hoursworked * hourlypayrate;
                        }
                        else
                        {
                            //calculate overtime hours
                            double overtimehours = hoursworked - 40;

                            // Regular pay + overtime hours
                            grosspay = (40 * hourlypayrate) + (overtimehours * hourlypayrate * 1.5);
                        }
                        //Display grosspay 
                        grosspaylbl.Text = grosspay.ToString("c2");
                    }
                    else
                    {
                        MessageBox.Show("Hourly pay rate cannot be negative");
                    }
                }
                else
                {
                    MessageBox.Show("Hours worked cannot be negative");
                }
            }
            catch 
            {
                //this runs the user enters invalid  text
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear
            txthoursworked.Clear();
            txthourlyrate.Clear();
            grosspaylbl.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
    }
}
