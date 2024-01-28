using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI__Business_Project_Airport__Final.DL;
using OOP_BUSINESS_PROJECT_FINAL.BL;
using OOP_BUSINESS_PROJECT_FINAL.DL;

namespace GUI__Business_Project_Airport__Final
{
    public partial class UC_AddressInfo : UserControl
    {
        Passenger p;
        bool check_f;
        bool check_e;
        bool check_s;
        bool check_st;
        bool check_p;
        public UC_AddressInfo(Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text == string.Empty)
            {// check is empty
                lblValidationCity.Text = "Enter the City Name";
                lblValidationCity.ForeColor = Color.Green;
                check_f = false;
            }

            else if (txtCity.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationCity.Text = "Allowed characters: a-z, A-Z";
                lblValidationCity.ForeColor = Color.Red;
                check_f = false;
            }
            else
            {//ready for storage or action
                lblValidationCity.Text = " ";
                check_f = true;
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (txtCountry.Text == string.Empty)
            {// check is empty
                lblValidationCountry.Text = "Enter the Country Name";
                lblValidationCountry.ForeColor = Color.Green;
                check_e = false;
            }

            else if (txtCountry.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationCountry.Text = "Allowed characters: a-z, A-Z";
                lblValidationCountry.ForeColor = Color.Red;
                check_e = false;
            }
            else
            {//ready for storage or action
                lblValidationCountry.Text = " ";
                check_e = true;
            }
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

            if (txtStreet.Text == string.Empty)
            {// check is empty
                lblValidationStreet.Text = "Enter the Street Name";
                lblValidationStreet.ForeColor = Color.Green;
                check_s = false;
            }

            else if (txtStreet.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationStreet.Text = "Allowed characters: a-z, A-Z";
                lblValidationStreet.ForeColor = Color.Red;
                check_s = false;
            }
            else
            {//ready for storage or action
                lblValidationStreet.Text = " ";
                check_s = true;
            }
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            if (txtState.Text == string.Empty)
            {// check is empty
                lblValidationState.Text = "Enter the State Name";
                lblValidationState.ForeColor = Color.Green;
                check_st = false;
            }

            else if (txtState.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationState.Text = "Allowed characters: a-z, A-Z";
                lblValidationState.ForeColor = Color.Red;
                check_st = false;
            }
            else
            {//ready for storage or action
                lblValidationState.Text = " ";
                check_st = true;
            }

        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtPostalCode.Text == string.Empty)
            {// check is empty
                lblValidationPostal.Text = "Enter the Postal Code";
                lblValidationPostal.ForeColor = Color.Green;
                check_p = false;
            }

            else if (txtPostalCode.Text.Any(ch => !char.IsDigit(ch)))

            {//check isSpecialCharactor
                lblValidationPostal.Text = "Allowed characters: 1- 9";
                lblValidationPostal.ForeColor = Color.Red;
                check_p = false;
            }
            else
            {//ready for storage or action
                lblValidationPostal.Text = "";
                
                check_p = true;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (check_f && check_e && check_s && check_st && check_p)
            {
                int length = 10; // Change this to set the desired length of the random string
                string randomString = GenerateRandomString(length);              
                address_user a = new address_user(txtStreet.Text,txtCity.Text,txtState.Text,txtPostalCode.Text,txtCountry.Text, randomString);
                Passenger passenger = new Passenger(p.Username, p.Password, p.Name, p.Lastname, p.Email, p.Cnic, p.Phonenumber, p.getnoofpeople(), p.getPin(), a, null , null , "");
                PassengerDL.updatePassenger(p, passenger);
                PassengerDL.storeallPassengersData("Passengers.txt");
                AddressDL.storeaddressofPassengers("Addresses.txt" , a);
                MessageBox.Show("Personal Info Addded");
            }
        }

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(chars, length)
                                          .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
