using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airline_Ticket_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // create variable 
            string Name;
            int Age;
            int numberofTickets;
            double baggageWeight;

            // assign value 
            Name = txtName.Text;

            // validate passenger name 
            if (Name == "")
            {
                MessageBox.Show("Enter Passenger Name");
                return;
            }

            // assign and validate passenger age 
            if (int.TryParse(txtAge.Text, out Age))
            {
                MessageBox.Show("Enter Valid Passenger Age");
                return;
            }

            if (Age < 1 || Age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100");
                return;
            }

            // assign and balidate number of ticked
            if (int.TryParse(txtTicked.Text, out numberofTickets))
            {
                MessageBox.Show("Enter Valid Number of Tickets");
                return;
            }

            if (numberofTickets < 1 || numberofTickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5");
                return;
            }

            // assign and validate baggage weight 
            if (double.TryParse(txtweight.Text, out baggageWeight))
            {
                MessageBox.Show("Enter Valid Baggage Weight");
                return;
            }

            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage must be between 0 and 50 kg");
                return;
            }

            // create travel class variable 
            string travelClass;

            //assign travel class 
            if (rbfirstclass.Checked)
            {
                if (Age < 12)
                {
                    MessageBox.Show("Below 12 cannot select First Class");
                    return;
                }

                travelClass = "First Class";
            }
            else if (rbNormal.Checked)
            {
                travelClass = "Normal Class";
            }
            else if (rbBusiness.Checked)
            {
                travelClass = "Business Class";
            }
            else
            {
                MessageBox.Show("Select Travel Class");
                return;
            }

            //  create cost variable
            double ticketPrice;
            double basicTicketCost;
            double discount;
            double insuranceCost;
            double totalAmount;

            //  assign cost value
            ticketPrice = 0;
            basicTicketCost = ticketPrice * numberofTickets;
            discount = 0;
            insuranceCost = 0;

            //  calculte ticked
            if (numberofTickets >= 3 && numberofTickets <= 4)
            {
                discount = basicTicketCost * 0.05;
            }
            else if (numberofTickets == 5)
            {
                discount = basicTicketCost * 0.10;
            }

            //  calculate age discount
            if (Age < 12)
            {
                discount = discount + basicTicketCost * 0.20;
            }
            else if (Age >= 60)
            {
                discount = discount + basicTicketCost * 0.10;
            }

            // calculate travel insurance 
            if (cbAddtravel.Checked)
            {
                insuranceCost = numberofTickets * 25;
            }

            // calculate total amount 
            totalAmount = basicTicketCost - discount + insuranceCost;

            // create baggage message variable
            string baggageMessage;

            // assign baggage message 
            if (baggageWeight <= 20)
            {
                baggageMessage = "Free";
            }
            else
            {
                baggageMessage = "Baggage Weight: " + baggageWeight + " kg";
            }

            // STEP 17: DISPLAY BOOKING DETAILS
            txtAirline.Text =
                "Airline Booking Details\n" +
                "Passenger Name: " + Name + "\n" +
                "Passenger Age: " + Age + "\n" +
                "Number of Tickets: " + numberofTickets + "\n" +
                "Baggage Weight: " + baggageWeight + " kg\n" +
                baggageMessage + "\n" +
                "Travel Class: " + travelClass + "\n" +
                "Basic Ticket Cost: $" + basicTicketCost + "\n" +
                "Discount: $" + discount + "\n" +
                "Travel Insurance: $" + insuranceCost + "\n" +
                "Total Amount: $" + totalAmount;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtTicked.Clear();
            txtweight.Clear();

            rbfirstclass.Checked = false;
            rbNormal.Checked = false;
            rbBusiness.Checked = false;
            cbAddtravel.Checked = false;

            txtAirline.Clear();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
