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
namespace GUI__Business_Project_Airport__Final
{
    public partial class UC_FlightsAdd : UserControl
    {

        bool check_id; 
        bool check_pr;
        bool update=false;
        Flight previous;



        public UC_FlightsAdd()
        {
            InitializeComponent();
        }

        public UC_FlightsAdd(bool check,Flight f)
        {
            InitializeComponent();
            update = check;
            previous = f;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }




        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.Text == "Business")
            {
                lblValidationCLass.ForeColor = Color.Green;
                lblValidationCLass.Text = "You choose Business Class !!!";

            }
            else
            {
                lblValidationCLass.Text = "You choose Economy Class!!!";
                lblValidationCLass.ForeColor = Color.Green;


            }
        }


       

       
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == string.Empty)
            {// check is empty
                lblValidationPrice.Text = "Enter the Ticket Price";
                lblValidationPrice.ForeColor = Color.Green;
                check_pr = false;
            }

            else if (txtPrice.Text.Any(ch => !char.IsDigit(ch)))

            {//check isSpecialCharactor
                lblValidationPrice.Text = "Allowed characters: 1 - 9 ";
                lblValidationPrice.ForeColor = Color.Red;
                check_pr = false;
            }
            else
            {//ready for storage or action
                lblValidationPrice.Text = " ";
                check_pr = true;
            }
        }

        private void btnCreatAccount_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";



            if (!update) // check if its working as add 
            {


                Flight f = new Flight(iDlbl.Text, cmbxFlightName.Text, cmbxFlightCurrentLoc.Text, cmbxDesiredLoc.Text, dateTimePicker1.Text, dateTimePicker2.Text, comboBoxClass.Text, cmbxMeal.Text, int.Parse(txtPrice.Text));
                FlightDL.addintolistflights(f);
                FlightDL.storeallFlightsRecord("Allflights.txt");
                MessageBox.Show("Added");

            }
            else
            {
                // agr form as an update khuly to create wala button as a update work kry
                Flight f = new Flight(iDlbl.Text, cmbxFlightName.Text, cmbxFlightCurrentLoc.Text, cmbxDesiredLoc.Text, dateTimePicker1.Text, dateTimePicker2.Text, comboBoxClass.Text, cmbxMeal.Text, int.Parse(txtPrice.Text));
                FlightDL.updateAflight(previous,f);
                FlightDL.storeallFlightsRecord("Allflights.txt");
                MessageBox.Show("Updated");


            }
            txtPrice.Text = string.Empty;
            iDlbl.Text = string.Empty;
            int length = 10; // Change this to set the desired length of the random string
            iDlbl.Text = GenerateRandomString(length);
        }

        private void UC_FlightsAdd_Load(object sender, EventArgs e)
        {
            // refresh krny ky lya
            cmbxMeal.Items.Clear();
            cmbxFlightCurrentLoc.Items.Clear();
            cmbxDesiredLoc.Items.Clear();
            //}
            int length = 10; // Change this to set the desired length of the random string
            iDlbl.Text = GenerateRandomString(length);
            

            List<string> countries = new List<string>
           {
            "Afghanistan",
            "Pakistan",
            "Albania",
            "Algeria",
            "Argentina",
            "Australia",
            "Brazil",
            "Canada",
            "China",
            "Egypt",
            "France",
            "Germany",
            "India",
            "Italy",
            "Japan",
            "Mexico",
            "Russia",
            "South Africa",
            "Spain",
            "United Kingdom",
            "United States"
           };

            List<string> countries2 = new List<string>
           {
            "Afghanistan",
            "Pakistan",
            "Albania",
            "Algeria",
            "Argentina",
            "Australia",
            "Brazil",
            "Canada",
            "China",
            "Egypt",
            "France",
            "Germany",
            "India",
            "Italy",
            "Japan",
            "Mexico",
            "Russia",
            "South Africa",
            "Spain",
            "United Kingdom",
            "United States"
           };


            List<string> flightFoodList = new List<string>
            {
            "Chicken or Beef",
            "Vegetarian Pasta",
            "Fish with Rice",
            "Grilled Chicken Salad",
            "Cheese and Fruit Platter",
            "Omelette with Hash Browns",
            "Shrimp Stir Fry",
            "BBQ Pork Ribs",
            "Mushroom Risotto",
            "Assorted Sandwiches",
            "Fruit Yogurt",
            "Cheese and Crackers",
            "Chocolate Cake",
            "Fresh Salad with Dressing",
            "Miso Soup",
            "Croissant with Jam",
            "Fried Rice with Vegetables",
            "Cheesecake",
            "Roast Beef with Mashed Potatoes",
            "Cup Noodles"
            
            };
            cmbxMeal.DataSource = flightFoodList;
            cmbxFlightCurrentLoc.DataSource = countries2;
            cmbxDesiredLoc.DataSource = countries;



            if (update)// agr form as an update khuly to create wala button as a update work kry
            {

                btnCreatAccount.Text = "Update";
                // SARY TEXT BOX COMBOBOX US HISAB SY SET KR DEIN GY 

                // update ho to pichky wala data dal do
                iDlbl.Text = previous.FlightID;
                cmbxFlightName.Text = previous.Nameofflight;
                cmbxDesiredLoc.Text = previous.Desired_location;
                cmbxFlightCurrentLoc.Text=previous.Current_location;
                cmbxMeal.Text = previous.Meal;
                dateTimePicker1.Text = previous.Departure_date;
                dateTimePicker1.Text=previous.Arrival_date;
                txtPrice.Text = previous.Bill_amount.ToString();
                comboBoxClass.Text=previous.Class_type;
                
            }
            else {
                btnCreatAccount.Text = "Create";
                update = false;
            }



        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
         
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            // Generate a random number part (excluding "ID")
            string randomNumber = new string(Enumerable.Repeat(chars, length - 2)
                                          .Select(s => s[random.Next(s.Length)]).ToArray());

            // Concatenate "ID" with the random number part
            string randomString = "ID" + randomNumber;
            return randomString;
        }

        private void cmbxFlightName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
