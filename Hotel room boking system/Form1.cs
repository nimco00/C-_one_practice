using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room_boking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  CREATE VARIABLES
            string guestName;
            string roomType = "";
            int age;
            int nights;
            int guests;
            int capacity;

            double roomRate;
            double roomCost;
            double breakfastCost;
            double subtotal;
            double discountRate;
            double discount;
            double seniorDiscount;
            double serviceCharge;
            double total;

            bool bookingApproved = true;
            bool breakfastSelected;
            bool ageValid;
            bool nightsValid;
            bool guestsValid;

            // ASSIGN VALUES
            guestName = txtName.Text.Trim();

            ageValid = int.TryParse(txtAge.Text, out age);
            nightsValid = int.TryParse(txtNight.Text, out nights);
            guestsValid = int.TryParse(txtGuests.Text, out guests);

            breakfastSelected = cbbreakfast.Checked;

            //  VALIDATE GUEST NAME
            if (guestName == "")
            {
                MessageBox.Show("Enter Guest Name.");
                bookingApproved = false;
            }

            //  VALIDATE AGE
            if (bookingApproved && ageValid)
            {
                MessageBox.Show("Enter a valid age.");
                bookingApproved = false;
            }

            //  VALIDATE NUMBER OF NIGHTS
            if (bookingApproved && nightsValid)
            {
                MessageBox.Show("Enter valid Number of Nights.");
                bookingApproved = false;
            }

            //  VALIDATE NUMBER OF GUESTS
            if (bookingApproved && guestsValid)
            {
                MessageBox.Show("Enter valid Number of Guests.");
                bookingApproved = false;
            }

            //  CHECK AGE RANGE
            if (bookingApproved && (age < 18 || age > 90))
            {
                MessageBox.Show("Age must be between 18 - 90");
                bookingApproved = false;
            }

            //  CHECK NIGHTS RANGE
            if (bookingApproved && (nights < 1 || nights > 30))
            {
                MessageBox.Show("Nights must be between 1 - 30");
                bookingApproved = false;
            }

            //  CHECK GUESTS RANGE
            if (bookingApproved && (guests < 1 || guests > 6))
            {
                MessageBox.Show("Guests must be between 1 - 6");
                bookingApproved = false;
            }

            //  SELECT ROOM TYPE
            if (bookingApproved)
            {
                if (rdstandard.Checked)
                    roomType = "Standard";
                else if (rdNormal.Checked)
                    roomType = "Normal";
                else if (rdhight.Checked)
                    roomType = "Hight";
                else
                {
                    MessageBox.Show("Select a Room Type.");
                    bookingApproved = false;
                }
            }

            // REJECT INVALID BOOKING
            if (bookingApproved)
            {
                txtBookingDetails.Text = "Booking Rejected";
                return;
            }

            //ASSIGN ROOM RATE AND CAPACITY
            switch (roomType)
            {
                case "Standard":
                    roomRate = 50;
                    capacity = 2;
                    break;

                case "Normal":
                    roomRate = 80;
                    capacity = 4;
                    break;

                case "Hight":
                    roomRate = 130;
                    capacity = 6;
                    break;

                default:
                    MessageBox.Show("Select a valid Room Type.");
                    txtBookingDetails.Text = "Booking Rejected";
                    return;
            }

            //  CHECK ROOM CAPACITY
            if (guests > capacity)
            {
                MessageBox.Show("Too many guests for this room.");
                txtBookingDetails.Text = "Booking Rejected";
                return;
            }

            //  CALCULATE ROOM COST
            roomCost = roomRate * nights;

            //  CALCULATE BREAKFAST COST
            if (breakfastSelected)
            {
                breakfastCost = 10 * guests * nights;
            }
            else
            {
                breakfastCost = roomCost - roomCost;
            }

            // CALCULATE SUBTOTAL
            subtotal = roomCost + breakfastCost;

            //  DETERMINE DISCOUNT RATE
            if (nights >= 10)
                discountRate = 0.12;
            else if (nights >= 5)
                discountRate = 0.05;
            else
                discountRate = subtotal - subtotal;

            //  CALCULATE NIGHT DISCOUNT
            discount = subtotal * discountRate;

            // : CALCULATE SENIOR DISCOUNT
            if (age >= 60)
            {
                seniorDiscount = (subtotal - discount) * 0.05;
            }
            else
            {
                seniorDiscount = subtotal - subtotal;
            }

            //  CALCULATE SERVICE CHARGE
            if (guests > 4)
            {
                serviceCharge =
                    (subtotal - discount - seniorDiscount) * 0.05;
            }
            else
            {
                serviceCharge = subtotal - subtotal;
            }

            // CALCULATE FINAL TOTAL
            total = subtotal - discount
                    - seniorDiscount + serviceCharge;

            //  DISPLAY BOOKING DETAILS
            txtBookingDetails.Text =
                "BOOKING APPROVED\n\n" +
                "Guest Name: " + guestName + "\n" +
                "Age: " + age + "\n" +
                "Room Type: " + roomType + "\n" +
                "Nights: " + nights + "\n" +
                "Guests: " + guests + "\n\n" +
                "Room Cost: $" + roomCost.ToString("F2") + "\n" +
                "Breakfast Cost: $" + breakfastCost.ToString("F2") + "\n" +
                "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                "Discount: $" + discount.ToString("F2") + "\n" +
                "Senior Discount: $" + seniorDiscount.ToString("F2") + "\n" +
                "Service Charge: $" + serviceCharge.ToString("F2") + "\n" +
                "TOTAL: $" + total.ToString("F2");
        }


    

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear
            txtName.Clear();
            txtAge.Clear();
            txtNight.Clear();
            txtGuests.Clear();
            txtBookingDetails.Clear();

            rdstandard.Checked = false;
            rdNormal.Checked = false;
            rdhight.Checked = false;
            cbbreakfast.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
    }
}
