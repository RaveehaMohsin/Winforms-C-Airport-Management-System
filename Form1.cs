using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI__Business_Project_Airport__Final.DL;
using OOP_BUSINESS_PROJECT_FINAL.DL;

namespace GUI__Business_Project_Airport__Final
{

    
    public partial class frmHomePage : Form
    {

        public frmHomePage()
        {
            InitializeComponent();
        }

        private void lblSignIN_Click(object sender, EventArgs e)
        {
            loadform(new UC_SignIn(this),this );

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
        public void loadform(object UserControl,Form frm)
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





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {    Datelbl.Text= DateTime.Now.ToString("dddd dd/MM/yyyy");

                timebl.Text = DateTime.Now.ToString("hh:mm:ss:tt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void ChangeScreen1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadform(new UC_SignUP());
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
           UserDL.readfromfileusers("usersdata.csv");
            FlightDL.readfromfileFlights("Allflights.txt");
            AddressDL.readfromfileAddress("Addresses.txt");
            luggageDL.readfromfileluggages("Luggages.txt");

            PassengerDL.readfromfilePassengers("Passengers.txt");
                PassengerDL.readfromfile("Feedbacks.txt");
            PassengerDL.readfromfilePassengersLuggages("PassengerLuggages.txt");
            Datelbl.ForeColor = Color.White;
            timebl.ForeColor = Color.White;

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeScreen_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Datelbl_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timebl_Click(object sender, EventArgs e)
        {

        }
    }
}
