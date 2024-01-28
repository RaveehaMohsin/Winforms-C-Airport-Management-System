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
    public partial class UC_PassengerInfo : UserControl
    {
        Form previous;
        Passenger p;
        bool check_f;
        bool check_e;
        bool check_c;
        bool check_l;
        bool check_p;
        bool check_pin;
        public UC_PassengerInfo(Passenger p,Form f)
        {
            InitializeComponent();
            this.p = p;
            this.previous = f;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {// check is empty
                lblValidationLNamePass.Text = "Enter the First Name";
                lblValidationLNamePass.ForeColor = Color.Red;
                check_f = false;
            }

            else if (txtName.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationLNamePass.Text = "Allowed characters: a-z, A-Z";
                lblValidationLNamePass.ForeColor = Color.Red;
                check_f = false;
            }
            else
            {//ready for storage or action
                lblValidationLNamePass.Text = "Valid";
                lblValidationLNamePass.ForeColor = Color.Green;
                check_f = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtLname.Text == string.Empty)
            {// check is empty
               lblValidationFnamePass.Text = "Enter the Last Name";
                lblValidationFnamePass.ForeColor = Color.Red;
                check_l = false;
            }

            else if (txtLname.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationFnamePass.Text = "Allowed characters: a-z, A-Z";
                lblValidationFnamePass.ForeColor = Color.Red;
                check_l = false;
            }
            else
            {//ready for storage or action
                lblValidationFnamePass.Text = "Valid";
                lblValidationFnamePass.ForeColor = Color.Green;
                check_l = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            if (txtCNIC.Text == string.Empty)
            {// check is empty
                lblValidationCNICPass.Text = "Enter the CNIC";
                lblValidationCNICPass.ForeColor = Color.Red;
                check_c = false;
            }
            if (txtCNIC.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblValidationCNICPass.Text = "Allowed characters: 1-9";
                lblValidationCNICPass.ForeColor = Color.Red;
                check_c = false;
            }

            else

            {//ready for storage or action
                lblValidationCNICPass.Text = "Valid";
                lblValidationCNICPass.ForeColor = Color.Green;

                check_c = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            check_e = IsValidEmail(txtEmail.Text);

            if (check_e == false)
            {
                lblValidationEmailPass.Text = "Enter valid email !!!";
                lblValidationEmailPass.ForeColor = Color.Red;
            }
            else 
            {
                lblValidationEmailPass.Text = "Valid";
                lblValidationEmailPass.ForeColor = Color.Green;
                
            }
            if (txtEmail.Text == string.Empty)
            {
                
                check_e = true; 
            }
        }
        bool IsValidEmail(string eMail)
        {
            bool Result = true;

            try
            {
                Regex emailRegex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

                // Check if the email matches the regular expression
                Result = emailRegex.IsMatch(eMail);

            }
            catch
            {
                Result = false;
            };

            return Result;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == string.Empty)
            {// check is empty
                lblValidationPhonePass.Text = "Enter the Number";
                lblValidationPhonePass.ForeColor = Color.Red;
                check_p = false;
            }
            if (txtPhone.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblValidationPhonePass.Text = "Allowed characters: 1-9";
                lblValidationPhonePass.ForeColor = Color.Red;
                check_p = false;
            }

            else

            {//ready for storage or action
                lblValidationPhonePass.Text = "Valid";
                lblValidationPhonePass.ForeColor = Color.Green;
                check_p = true;
            }
        }

     

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddress_Click(object sender, EventArgs e)
        {

            if (check_c && check_e && check_f && check_p && check_pin && check_l)
            {
                Passenger passenger = new Passenger(p.Username, p.Password, txtName.Text, txtLname.Text, txtEmail.Text, double.Parse(txtCNIC.Text), txtPhone.Text, int.Parse(numericUpDownFamily.Value.ToString()), int.Parse(txtPin.Text), null, null, null, "");
                PassengerDL.updatePassenger(p, passenger);
                Passenger x = PassengerDL.getupdatedpassenger(passenger);
                PassengerInterface f = new PassengerInterface(x, true);
                this.Hide();
                previous.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Enter complete Info");
            }

        }

        public void loadform(object UserControl)
        {
            try
            {
                this.ChangeScreenInfo.Controls.Clear();
                UserControl f = UserControl as UserControl;
                f.Dock = DockStyle.Fill;
                this.ChangeScreenInfo.Controls.Add(f);
                this.ChangeScreenInfo.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtPin_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPin.Text == string.Empty)
            {// check is empty
               lblValidationAccPinPass.Text = "Enter the Number";
                lblValidationAccPinPass.ForeColor = Color.Red;
                check_pin = false;
            }
            if (txtPin.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblValidationAccPinPass.Text = "Allowed characters: 1-9";
                lblValidationAccPinPass.ForeColor = Color.Red;
                check_pin = false;
            }

            else

            {//ready for storage or action
                lblValidationAccPinPass.Text = "Valid";
                lblValidationAccPinPass.ForeColor = Color.Green;
                check_pin = true;
            }
        }
    }
}
