using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_sles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //variable
                int NumberOfPackages;
                double PricePerPackage;


                if (int.TryParse(txtNumber.Text, out NumberOfPackages) && double.TryParse(txtprice.Text, out PricePerPackage))
                {
                    NumberOfPackages = int.Parse(txtNumber.Text);
                    PricePerPackage = double.Parse(txtprice.Text);

                    //subtotal Before Discount
                    double SubTotal;

                    SubTotal = NumberOfPackages * PricePerPackage;

                    //Discount Rate
                    double discountRate = 0;

                    //Discount Amount
                    double discountAmount = 0;
                    //validation number check
                    if (NumberOfPackages < 0)
                    {
                        MessageBox.Show("Negative lama ogolo numberkaa soo gelineysid");
                        return;
                    }
                    // calculating discount
                    if (NumberOfPackages >= 10 && NumberOfPackages <= 19)
                    {
                        discountAmount = SubTotal * 0.2;
                        discountRate = 20;
                    }
                    else if (NumberOfPackages >= 20 && NumberOfPackages <= 49)
                    {
                        discountAmount = SubTotal * 0.3;
                        discountRate = 30;
                    }
                    else if (NumberOfPackages >= 50 && NumberOfPackages <= 99)
                    {
                        discountAmount = SubTotal * 0.4;
                        discountRate = 40;
                    }
                    else if (NumberOfPackages >= 100)
                    {
                        discountAmount = SubTotal * 0.5;
                        discountRate = 50;
                    }
                    


                    //total
                    double Total;
                    Total = SubTotal - discountAmount;

                    //list box
                    listresult.Items.Add("Number Of Packages : " + NumberOfPackages);
                    listresult.Items.Add("Price Per Package : $ " + PricePerPackage);
                    listresult.Items.Add("Subtotal(Before Discount) : $ " + SubTotal);
                    listresult.Items.Add("Discount Rate : " + discountRate);
                    listresult.Items.Add("Discount Amount : " + discountAmount);
                    listresult.Items.Add("Total Amount (After Discount) : " + Total);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtprice.Clear();

            listresult.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        

