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
    public partial class UC_FlightSelect : UserControl
    {
        public UC_FlightSelect()
        {
            InitializeComponent();
        }

        private void dataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flight f = (Flight)dataGridViewFlights.CurrentRow.DataBoundItem;
            if (dataGridViewFlights.Columns["Select"].Index == e.ColumnIndex)
            {
                f = FlightDL.selectedflight(f.FlightID);


            }

        }
  

   

        private void btnQatar_Click(object sender, EventArgs e)
        {
            List<Flight> qatarFlights = new List<Flight>();
            qatarFlights = FlightDL.returnflights("Qatar");
            dataBind(qatarFlights);
        }

        private void btnPIA_Click_1(object sender, EventArgs e)
        {
            List<Flight> piaFligts = new List<Flight>();
            piaFligts = FlightDL.returnflights("PIA");
            dataBind(piaFligts);
        }

        private void btnSouthwest_Click_1(object sender, EventArgs e)
        {
            List<Flight> southestFlights = new List<Flight>();
            southestFlights = FlightDL.returnflights("SouthWest Airlines");
            dataBind(southestFlights);
        }

        private void btnEmirates_Click_1(object sender, EventArgs e)
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

        private void btnTHAI_Click_1(object sender, EventArgs e)
        {
            List<Flight> thaiflights = new List<Flight>();
            thaiflights = FlightDL.returnflights("Thai Airlines");
            dataBind(thaiflights);
        }

    }
}
