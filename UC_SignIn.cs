using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_BUSINESS_PROJECT_FINAL.BL;
using OOP_BUSINESS_PROJECT_FINAL.DL;
using GUI__Business_Project_Airport__Final;

namespace GUI__Business_Project_Airport__Final
{
    public partial class UC_SignIn : UserControl
    {
        bool check_f;
        bool check_c;
        Form y;

        public UC_SignIn()
        {
            InitializeComponent();
        }
        public UC_SignIn(Form x)
        {
            InitializeComponent();
            y = x;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNameSignUp_TextChanged(object sender, EventArgs e)
        {
            
            if (txtNameSignIn.Text == string.Empty)
            {// check is empty
                lblValidationNameSignIn.Text = "Enter the Name";
                lblValidationNameSignIn.ForeColor = Color.Red;
                check_f = false;
            }

            else if (txtNameSignIn.Text.Any(ch => !char.IsLetter(ch)))

            {//check isSpecialCharactor
                lblValidationNameSignIn.Text = "Allowed characters: a-z, A-Z";
                lblValidationNameSignIn.ForeColor = Color.Red;
                check_f = false;
            }
            else
            {//ready for storage or action
                lblValidationNameSignIn.Text = "Valid Data";
                lblValidationNameSignIn.ForeColor = Color.Green;
                check_f = true;
            }
        }

        private void txtPasswordSignIn_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPasswordSignIn.Text == string.Empty)
            {// check is empty
                lblValidationPasswordSignin.Text = "Enter the Password";
                lblValidationPasswordSignin.ForeColor = Color.Red;
                check_c = false;
            }

            else if (txtPasswordSignIn.Text.Any(ch => !char.IsDigit(ch)))

            {//check isSpecialCharactor
                lblValidationPasswordSignin.Text = "Allowed characters: 1 - 9 ";
                lblValidationPasswordSignin.ForeColor = Color.Red;
                check_c = false;
            }
            else
            {//ready for storage or action
                lblValidationPasswordSignin.Text = "Valid Data";
                lblValidationPasswordSignin.ForeColor = Color.Green;
                check_c = true;
            }
        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            if(check_c && check_f)
            {
                User u = new User(txtNameSignIn.Text, txtPasswordSignIn.Text);
                if (User.signin(u))
                {
                    MessageBox.Show("Successfully Signed In");
                    u=User.GetUSer(u);
                    if (u.Role == "Admin") {

                        AdminInterface x = new AdminInterface();
                        x.Show();
                    }
                    else if (u.Role == "Passenger")
                    {
                        Passenger p=PassengerDL.checkpassenger(u);
                        PassengerInterface r = new PassengerInterface(p);
                        r.Show();
                    }
                    // fform close too
                    y.Hide();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("User Not Found");
                }
            }
        }
    }
}
