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
    public partial class PassengerInterface : Form
    {

        Passenger p;

        bool chec;
        public PassengerInterface(Passenger p)
        {
            InitializeComponent();
            this.p = p;
            chec = false;

        }
        public PassengerInterface(Passenger p, bool check)
        {
            InitializeComponent();
            this.p = p;
            chec = check;
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadform(object UserControl)
        {
            try
            {
                this.ChangeScreen.Controls.Clear();
                UserControl f = UserControl as UserControl;
                f.Dock = DockStyle.Fill;
                this.ChangeScreen.Controls.Add(f);
                this.ChangeScreen.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblAirlines_Click(object sender, EventArgs e)
        {
            Passenger x = PassengerDL.getupdatedpassenger(p);

            loadform(new UC_FlightsNameOption(x));
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            loadform(new UC_PassengerInfo(p, this));
        }

        private void PassengerInterface_Load(object sender, EventArgs e)
        {
            FlightDL.flights.Clear();
            FlightDL.readfromfileFlights("Allflights.txt");
            if (chec == true)
            {
                loadform(new UC_AddressInfo(p));
            }
            else
            {

            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            frmHomePage f = new frmHomePage();
            f.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Passenger x = PassengerDL.getupdatedpassenger(p);
            loadform(new UC_Luggage(x));
            

        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            Passenger x = PassengerDL.getupdatedpassenger(p);
            loadform(new UC_FeedBack(x));
        }

        private void lblBooking_Click(object sender, EventArgs e)
        {
            Passenger x = PassengerDL.getupdatedpassenger(p);
            loadform(new UC_Booking(x));
        }
    }
}
