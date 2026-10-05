using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variable
                double Score1;
                double Score2;
                double Score3;

                //check the first score
                if(double.TryParse(txtTestScore1.Text,out Score1))
                {
                    MessageBox.Show("please enter a valid Score 1.");
                }
                //check the second score
                else if(double.TryParse(txtTestScore2.Text, out Score2))
                {
                    MessageBox.Show("please enter a valid Score 2.");
                }
                //check the third score
                else if (double.TryParse(txtTestScore3.Text, out Score3))
                {
                    MessageBox.Show("please enter a valid Score 3.");
                }
                //if all three scores are valid
                else
                {
                    //Calculate the average
                    double average = (Score1 + Score2 + Score3) / 3;

                    //Display the average 
                    lbloutput.Text = average.ToString("0.0");
                }




            }
            catch { 
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear all textboxes
            txtTestScore1.Clear();
            txtTestScore2.Clear();
            txtTestScore3.Clear();
            lbloutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
