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
    public partial class UC_FlightsCRUD : UserControl
    {
        bool close_previous_admin_interface;
        Form form_previous;

        public UC_FlightsCRUD()
        {
            InitializeComponent();
        }

        public UC_FlightsCRUD(bool close_previous_admin_interface, Form f)
        {
            InitializeComponent();
            this.close_previous_admin_interface = close_previous_admin_interface;
            this.form_previous = f;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }
        
        private void UC_FlightsCRUD_Load(object sender, EventArgs e)
        {
           
            dataBind();
            dataGridView1.Columns["Delete"].ToolTipText ="Delete";
            dataGridView1.Columns["Delete"].HeaderText = "Delete";


        }

        // is function ko call krny sy data grid ma value list ajay gi

        public void dataBind() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FlightDL.flights;
            dataGridView1.Refresh();

        
        }
        // ya waly function ma 2 buttons add ho gy huwy grid sy edit colums kr ky 
        // ab un 2 buttons ko click kr ky jo b chhaty wo krna ha
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flight f = (Flight)dataGridView1.CurrentRow.DataBoundItem;
            // is wali line sy current row jo ap choose kro gy wo us ky sara data ko
            // as flight type object return kr dy ga
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                // if ma ya condition ha ky check ho ky agr selected coloumn ma 
                // hum ny update wala column aik sepecifc row ma sy sellect kya ha grid ma sy to
                // ya kry

                f = FlightDL.selectedflight(f.FlightID);
                // hum ny us selected flight ko check kya ky list ma ha to us ka object return kry

                FlightDL.flights.Remove(f);
                // us ko list sy remove kya
                FlightDL.storeallFlightsRecord("Allflights.txt");
                // jo list update hoi us ko store kya
                dataBind();
                // data grid ma data refresh kya

            }
            else if (dataGridView1.Columns["Update"].Index == e.ColumnIndex) 
            {
                AdminInterface form = new AdminInterface(true,f);
                form_previous.Hide(); // previous admin interface hide 
                form.ShowDialog();
                this.Hide();

            }
        }


    }
}
