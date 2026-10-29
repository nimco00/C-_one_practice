using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3_examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // creatig variables
            double validation;

            if (double.TryParse(txtsalary.Text, out validation) && double.TryParse(txtexp.Text, out validation))
            {
                try
                {
                    double salary, years;

                    salary = double.Parse(txtsalary.Text);
                    years = double.Parse(txtexp.Text);

                    if (salary >= 200)
                    {
                        if (years >= 2)
                        {
                            lblresult.Text = "Waa laguu ogolyahay Deynta";
                        }
                        else
                        {
                            lblresult.Text = "Waqtiga aad shaqaynaysay waaka yaryahay 2 sano";
                        }
                    }
                    else
                    {
                        lblresult.Text = "Mushaarkaada kuma filna deenqaadasho.";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("exception");
                }

            }
            else
            {
                MessageBox.Show("Salary or years experiance only double or integer");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear

            txtsalary.Clear();
            txtexp.Clear();
            lblresult.Text = "";
        }
    }
}
