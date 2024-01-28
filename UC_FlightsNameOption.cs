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
    public partial class UC_FlightsNameOption : UserControl
    {
        Passenger p;
        public UC_FlightsNameOption(Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void pbBoxQatar_Click(object sender, EventArgs e)
        {

        }

        private void pbBoxSouthWest_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Flight f = (Flight)dataGridViewFlights.CurrentRow.DataBoundItem;
            
            f = FlightDL.selectedflight(f.FlightID);
            if (f.Nameofflight == "Thai Airlines")
            {
                Thai t = new Thai(f.FlightID, f.Nameofflight, f.Current_location, f.Desired_location, f.Arrival_date, f.Departure_date, f.Class_type, f.Meal, f.Bill_amount);
                f = t;
            }
            else if (f.Nameofflight == "Emirates")
            {
                Emirates emi = new Emirates(f.FlightID, f.Nameofflight, f.Current_location, f.Desired_location, f.Arrival_date, f.Departure_date, f.Class_type, f.Meal, f.Bill_amount);
                f = emi;
            }
            else if (f.Nameofflight == "Qatar")
            {
                Qatar q = new Qatar(f.FlightID, f.Nameofflight, f.Current_location, f.Desired_location, f.Arrival_date, f.Departure_date, f.Class_type, f.Meal, f.Bill_amount);
                f = q;
            }
            else if (f.Nameofflight == "PIA")
            {
                PIA pia = new PIA(f.FlightID, f.Nameofflight, f.Current_location, f.Desired_location, f.Arrival_date, f.Departure_date, f.Class_type, f.Meal, f.Bill_amount);
                f = pia;
            }
            else if (f.Nameofflight == "SouthWest Airlines")
            {
                SouthWest sw = new SouthWest(f.FlightID, f.Nameofflight, f.Current_location, f.Desired_location, f.Arrival_date, f.Departure_date, f.Class_type, f.Meal, f.Bill_amount);
                f = sw;
            }


            PassengerDL.passengerFlights.Add(f);

            if (dataGridViewFlights.Columns["Select"].Index == e.ColumnIndex)
            {
                Passenger passenger = new Passenger(p.Username, p.Password, p.Name, p.Lastname, p.Email, p.Cnic, p.Phonenumber, p.getnoofpeople(), p.getPin(), p.Address, f , null , "");
               
                PassengerDL.updatePassenger(p, passenger);
                PassengerDL.storeallPassengersData("Passengers.txt");
                MessageBox.Show("Selected Flight is Added");
            }

           
        }

        private void btnTHAI_Click(object sender, EventArgs e)
        {
            List<Flight> thaiflights = new List<Flight>();
            thaiflights = FlightDL.returnflights("Thai Airlines");
            dataBind(thaiflights);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Flight> qatarFlights = new List<Flight>();
            qatarFlights = FlightDL.returnflights("Qatar");
            dataBind(qatarFlights);
        }

        private void btnPIA_Click(object sender, EventArgs e)
        {
            List<Flight> piaFligts = new List<Flight>();
            piaFligts = FlightDL.returnflights("PIA");
            dataBind(piaFligts);
        }

        private void btnSouthwest_Click(object sender, EventArgs e)
        {
            List<Flight> southestFlights = new List<Flight>();
            southestFlights = FlightDL.returnflights("SouthWest Airlines");
            dataBind(southestFlights);
        }

        private void btnEmirates_Click(object sender, EventArgs e)
        {
            List<Flight> emiratesFlights = new List<Flight>();
            emiratesFlights = FlightDL.returnflights("Emirates");
            dataBind(emiratesFlights);
            
        }

        public void dataBind(List<Flight> flights)
        {
            dataGridViewFlights.DataSource = null;
            dataGridViewFlights.DataSource = flights;
            dataGridViewFlights.Refresh();


        }
    }
}
