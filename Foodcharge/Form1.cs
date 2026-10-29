using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodcharge
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
          
                // declaring the varibales to store the data from textbox's
                string food1name = txtFood1.Text;
                string food2name = txtFood2.Text;
                double food1price = double.Parse(txtPrice1.Text);
                double food2price = double.Parse(txtPrice2.Text);

                // creating the const tax variable
                const double Tax = 7;

                // calculate the sum food charge meal
                double sum = food1price + food2price;

                // calculate the tax of the food charge
                double calculatePercentage = (sum * Tax) / 100;

                // calculate total amount
                double total = sum + calculatePercentage;

                // displaying the outputs
                lbloutputofsum.Text = sum.ToString();
                lblSalexText.Text = calculatePercentage.ToString();
                lblTotalAmount.Text = total.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
