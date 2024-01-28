using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_BUSINESS_PROJECT_FINAL.BL;
using OOP_BUSINESS_PROJECT_FINAL.DL;

namespace GUI__Business_Project_Airport__Final
{
    public partial class UC_SignUP : UserControl
    {
        bool check_n;
        bool check_p;
        public UC_SignUP()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSignIN_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblValidationRole_Click(object sender, EventArgs e)
        {

        }

        private void txtNameSignUp_TextChanged(object sender, EventArgs e)
        {
           
            if (txtNameSignUp.Text == string.Empty)
            {// check is empty
                lblValidation.Text = "Enter the Name";
                lblValidation.ForeColor = Color.Red;
                check_n = false;
            }
            
            else if (txtNameSignUp.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidation.Text = "Allowed characters: a-z, A-Z";
                lblValidation.ForeColor = Color.Red;
                check_n= false;
            }
            else
            {//ready for storage or action
                lblValidation.Text = "Valid Data";
                lblValidation.ForeColor = Color.Green;
                check_n = true;
            }
        }

        private void txtPasswordSignUp_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPasswordSignUp.Text == string.Empty)
            {// check is empty
                lblValidationPassword.Text = "Enter the Password";
                lblValidationPassword.ForeColor = Color.Red;
                check_p = false;
            }

            else if (txtPasswordSignUp.Text.Any(ch => !char.IsDigit(ch)))

            {//check isSpecialCharactor
                lblValidationPassword.Text = "Allowed characters: 1 - 9 ";
                lblValidationPassword.ForeColor = Color.Red;
                check_p = false;
            }
            else
            {//ready for storage or action
                lblValidationPassword.Text = "Valid Data ";
                lblValidationPassword.ForeColor = Color.Green;
                check_p = true;
            }
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxRole.Text == "Admin" )
            {
                lblValidationRole.ForeColor = Color.Green;
                lblValidationRole.Text = "You choose role as an ADMIN !!!";

            }
            else 
            {
                lblValidationRole.Text = "You choose role as a Passenger!!!";
                lblValidationRole.ForeColor = Color.Green;


            }
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (check_n && check_p && cmbxRole.Text!=string.Empty)
            {

                if (cmbxRole.Text == "Admin")
                {

                    OOP_BUSINESS_PROJECT_FINAL.BL.User user = new User(txtNameSignUp.Text, txtPasswordSignUp.Text, cmbxRole.Text);
                    OOP_BUSINESS_PROJECT_FINAL.DL.UserDL.addtolist(user);
                    OOP_BUSINESS_PROJECT_FINAL.DL.UserDL.storeUsers("usersdata.csv", user);

                }

                else {
                    OOP_BUSINESS_PROJECT_FINAL.BL.User user = new User(txtNameSignUp.Text, txtPasswordSignUp.Text, cmbxRole.Text);
                    OOP_BUSINESS_PROJECT_FINAL.DL.UserDL.addtolist(user);
                    OOP_BUSINESS_PROJECT_FINAL.DL.UserDL.storeUsers("usersdata.csv", user);

                    Flight f = new Flight();
                address_user a = new address_user();
                Luggage lugg = new Luggage();
                OOP_BUSINESS_PROJECT_FINAL.BL.Passenger passenger = new Passenger(user.Username, txtPasswordSignUp.Text, string.Empty, string.Empty , string.Empty , 0 , string.Empty , 0 , 0 , a, f , lugg , "" );
                OOP_BUSINESS_PROJECT_FINAL.DL.PassengerDL.addintolistpassenger(passenger);
                OOP_BUSINESS_PROJECT_FINAL.DL.PassengerDL.storeallPassengersData("Passengers.txt",passenger);

                }
                MessageBox.Show("Data Entered Correctly in CSV files");
                txtNameSignUp.Text = string.Empty;
                txtPasswordSignUp.Text = string.Empty;


            }
            else 
            {
                MessageBox.Show("Enter Complete Data");
            }
         
        }
    }
}
