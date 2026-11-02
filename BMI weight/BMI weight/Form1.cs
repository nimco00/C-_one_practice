using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Create variable
            double height;
            double weight;
            double calculate;
            //Try parse
            if (double.TryParse(txtweight.Text,out weight)&double.TryParse(txtheight.Text,out height)) {
                double.Parse(txtweight.Text);
                double.Parse(txtheight.Text);
                calculate = weight * 703 / (height*height);
                double Result = calculate;

                //condition
                if (weight < 18.5)
                {
                    listoutput.Items.Add("Under Weight");
                    listoutput.Items.Add(Result + "KG");
                }
                else if (weight >= 18.5 && weight <= 25)
                {

                    listoutput.Items.Add("Optimal Weight");
                    listoutput.Items.Add(Result + "KG");
                }
                else if (weight > 25)
                {
                    listoutput.Items.Add("over Weight");
                    listoutput.Items.Add(Result + "KG");
                }
                else
                {
                    MessageBox.Show("soo gali weight");
                }
            } 
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear

            txtheight.Clear();
            txtweight.Clear();
            listoutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close
            this.Close();  
        }
    }
}