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
    public partial class UC_ViewAllPassengers : UserControl
    {
        public UC_ViewAllPassengers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void dataBind(List<Passenger> passengers)
        {
            
                var displayList = passengers.Select(p => new { p.Username, p.Password, p.Name, p.Lastname, p.Email, p.Cnic, p.Phonenumber, p.Amountofpeople, p.Pin, city = p.Address.Id, ID = p.Passengerflight.FlightID , IDLuggage = p.Passengerluggage.LuggageID }).ToList();

                dataGridViewPassengers.DataSource = null;
                dataGridViewPassengers.DataSource = displayList;
 
                dataGridViewPassengers.Columns["UserName"].HeaderText = "UserName";
                dataGridViewPassengers.Columns["Password"].HeaderText = "Password";
                dataGridViewPassengers.Columns["Name"].HeaderText = "First Name";
                dataGridViewPassengers.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewPassengers.Columns["Email"].HeaderText = "E-mail";
                dataGridViewPassengers.Columns["CNIC"].HeaderText = "CNIC";
                dataGridViewPassengers.Columns["Phonenumber"].HeaderText = "Phone No#";
                dataGridViewPassengers.Columns["Amountofpeople"].HeaderText = "Family Members";
                dataGridViewPassengers.Columns["Pin"].HeaderText = "Account Pin";
                dataGridViewPassengers.Columns["city"].HeaderText = "Address ID";
                dataGridViewPassengers.Columns["ID"].HeaderText = "Flight ID";
                dataGridViewPassengers.Columns["IDLuggage"].HeaderText = "Luggage ID";

            dataGridViewPassengers.Refresh();
            
                     

        }

        private void UC_ViewAllPassengers_Load(object sender, EventArgs e)
        {
            dataBind(PassengerDL.passengers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
