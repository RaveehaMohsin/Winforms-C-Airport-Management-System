using OOP_BUSINESS_PROJECT_FINAL.BL;
using OOP_BUSINESS_PROJECT_FINAL.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI__Business_Project_Airport__Final
{
    public partial class UC_Luggage : UserControl
    {
        Passenger p;
        bool check_f;
      
        public UC_Luggage(Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void txtLuggageType_TextChanged(object sender, EventArgs e)
        {
            if (txtLuggageType.Text == string.Empty)
            {// check is empty
                lblValidationType.Text = "Enter Luggage Type";
                lblValidationType.ForeColor = Color.Red;
                check_f = false;
            }

            else if (txtLuggageType.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationType.Text = "Allowed characters: a-z, A-Z";
                lblValidationType.ForeColor = Color.Red;
                check_f = false;
            }
            else
            {//ready for storage or action
                lblValidationType.Text = "Valid";
                lblValidationType.ForeColor = Color.Green;
                check_f = true;
            }
        }

       

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (check_f)
            {
                int length = 10; 
                string id = GenerateRandomString(length);
                Luggage l = new Luggage(txtLuggageType.Text, cmbxWeight.Text , id);
                Passenger passenger = new Passenger(p.Username, p.Password, p.Name, p.Lastname, p.Email, p.Cnic, p.Phonenumber, p.Amountofpeople, p.Pin, p.Address, p.Passengerflight, l , "");
                PassengerDL.updatePassenger(p, passenger);
                luggageDL.storeluggagesofPassengers("Luggages.txt", l);
                PassengerDL.storeallPassengersLuggages("PassengerLuggages.txt", passenger);
                PassengerDL.storeallPassengersData("Passengers.txt");
                MessageBox.Show("Luggage Added Successfully!");
            }
            else
            {
                MessageBox.Show("Enter complete info!");
            }

                
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Luggage_Load(object sender, EventArgs e)
        {

        }
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(chars, length)
                                          .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
