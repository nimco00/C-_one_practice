using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
           
            //calculate variable validate number of course
            int validate;
            if (int.TryParse(txtnumbercourse.Text,out validate))
            {
                try
                {
                    string name = txtstudentname.Text;
                    int id = int.Parse(txtstudentid.Text);
                    int level = int.Parse(txtstudentlevel.Text);
                    int course = int.Parse(txtnumbercourse.Text);
                    double transport = double.Parse(txttransportoption.Text);
                    double tutionfee = 0;
                    double Discount = 0;
                    double finalregistration =0;

                    if (course >= 1 && course <= 8)
                    {
                        if (level == 1)
                        {
                            tutionfee = course * 40;
                        }
                        else if (level == 2)
                        {
                            tutionfee = course * 45;

                        }
                        else if (level == 3)
                        {
                            tutionfee = course * 50;

                        }
                        else if (level == 4) {
                            tutionfee = course * 55;

                        }
                        else
                        {
                            MessageBox.Show("the level must betwen 1 & 4");
                        }
                        //Discount
                        if (course >= 6)
                        {
                            Discount = tutionfee * 0.10;
                        }
                        //final amount
                        finalregistration = tutionfee + transport - Discount;
                        //display
                        Namelbl.Text= name;
                        idlbl.Text=id.ToString();
                        studylevellbl.Text=level.ToString();
                        Discontlbl.Text=Discount.ToString();
                        Transportlbl.Text=transport.ToString();
                        tuitionfeelbl.Text=tutionfee.ToString();
                        finallbl.Text=finalregistration.ToString();
                        

                    }
                    else
                    {
                        MessageBox.Show("the number of course must betwen 1 & 8");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                   
            }
            else
            {
                MessageBox.Show("enter integer value");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //claer
            txtstudentname.Clear();
            txtstudentid.Clear();
            txtnumbercourse.Clear();
            txtstudentlevel.Clear();
            txttransportoption.Clear();

            Namelbl.Text=string.Empty;
            idlbl.Text = string.Empty;
            studylevellbl.Text = string.Empty;
            tuitionfeelbl.Text = string.Empty;
            Discontlbl.Text = string.Empty;
            Transportlbl.Text = string.Empty;
            finallbl.Text = string.Empty;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close or exit
            this.Close();
        }
    }
}
