using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {

                //Declare Variable
                int NUMBER;

                //Try to convert the textBox value to an integer
                if (int.TryParse(txtnumber.Text, out NUMBER))
                {
                    //Check if number is between 1 to 10
                    if (NUMBER >= 1 && NUMBER <= 10)
                    {

                        lblDecision.Text = "the number is in the range ";
                    }
                    else
                    {
                        lblDecision.Text = "the number  outside the range ";

                    }
                }
                else
                {
                    MessageBox.Show("please enter a valid integer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear
            txtnumber.Clear();
            lblDecision.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
    }
}
