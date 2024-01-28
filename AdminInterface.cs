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
    public partial class AdminInterface : Form
    {
        bool check_flight_update=false;
        Flight f; // ya wo wla object ho ga jis ko hum update ky la pass kry gy



        public AdminInterface()
        {
            InitializeComponent();
        }

        public AdminInterface(bool check_flight_add_update, Flight f)
        {
            InitializeComponent();
            this.check_flight_update = check_flight_add_update;
            this.f = f;
        }

        private void ChangeScreen1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFlightaAdminInterface_Click(object sender, EventArgs e)
        {
            if (!check_flight_update)
            {
                loadform(new UC_FlightsAdd());
            }
            else { 
            loadform(new UC_FlightsAdd(true,f)); 
            }
     
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

        private void lblExit_Click(object sender, EventArgs e)
        {
            frmHomePage f = new frmHomePage();
            f.Show();
            this.Close();
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            FlightDL.flights.Clear();
            FlightDL.readfromfileFlights("Allflights.txt");
            if (check_flight_update) loadform(new UC_FlightsAdd(true, f));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadform(new UC_FlightsCRUD(true, this));
        }

        private void lblPassengersAdminInterface_Click(object sender, EventArgs e)
        {
            loadform(new UC_ViewAllPassengers());
        }

        private void lblLuggageAdminInterface_Click(object sender, EventArgs e)
        {
            loadform(new UC_LuggageView());
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            loadform(new UC_FeedbackView());
        }
    }
}
