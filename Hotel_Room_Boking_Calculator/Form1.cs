using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Boking_Calculator
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
                // create variables TextBoxes


                String Guest_Name, room;
                int  Numbernight;
                double price;
                double service;
                double Discount;
                double Total;

                ///assign varibles 
                Guest_Name = txtGuestName.Text;
                room = txtRoomType.Text;
                Numbernight = int.Parse(txtNights.Text);
                price = double.Parse(txtPriceNight.Text);
               



                //Calculate booking cost
                  double subtotal = Numbernight * price;
                   service = subtotal * 0.10;
                 Discount = subtotal * 0.05;
                Total = (subtotal * 2) + service - Discount;

                // Display results
                lblServiceTax.Text =  service.ToString("C2");
                lblDiscount.Text =  Discount.ToString("C2");
                lblTotalAmount.Text = Total.ToString("C2");



            }
            // // Display an error message if the user enters invalid information
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
