using OOP_BUSINESS_PROJECT_FINAL.BL;
using OOP_BUSINESS_PROJECT_FINAL.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI__Business_Project_Airport__Final
{
    public partial class UC_FeedBack : UserControl
    {
        Passenger p;
        public UC_FeedBack(Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPoor.Checked) 
            {
                label2.Visible = true;
                richTextBox1.Visible = true;
            }
        }

        private void UC_FeedBack_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            richTextBox1.Visible =false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rdbtnPoor.Checked)
            {
                rdbtnSatisfactory.Checked = false;
                rdBtnGood.Checked = false;
                rdbtnExcellent.Checked = false;
               

            }
            else if (rdbtnExcellent.Checked)
            {
                rdbtnSatisfactory.Checked = false;
                rdBtnGood.Checked = false;
                rdbtnPoor.Checked = false;
                label2.Visible = false;
                richTextBox1.Visible = false;

            }
            else if (rdBtnGood.Checked)
            {
                rdbtnSatisfactory.Checked = false;
                rdbtnPoor.Checked = false;
                rdbtnExcellent.Checked = false;
                label2.Visible = false;
                richTextBox1.Visible = false;

            } else if(rdbtnSatisfactory.Checked)
            {

                rdBtnGood.Checked = false;
                rdbtnPoor.Checked = false;
                rdbtnExcellent.Checked = false;
                label2.Visible = false;
                richTextBox1.Visible = false;

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (rdbtnPoor.Checked)
            {
                p.Review = rdbtnPoor.Text;
                PassengerDL.updatePassenger(p, p);
                Passenger passenger = new Passenger(p.Name, rdbtnPoor.Text);
                PassengerDL.addreviewintolist(passenger);
                PassengerDL.storeallPassengersData("Passengers.txt");
                PassengerDL.storeReviewsofPassengers("Feedbacks.txt", passenger);
                
                MessageBox.Show(" FeedBack  Added");
            }
            else if (rdbtnExcellent.Checked)
            {
                p.Review = rdbtnExcellent.Text;
                PassengerDL.updatePassenger(p, p);
                Passenger passenger = new Passenger(p.Name, rdbtnExcellent.Text);
                PassengerDL.addreviewintolist(passenger);
                PassengerDL.storeallPassengersData("Passengers.txt");
                PassengerDL.storeReviewsofPassengers("Feedbacks.txt", passenger);
                MessageBox.Show("Added");
            }

            else if (rdBtnGood.Checked)
            {
                p.Review = rdBtnGood.Text;
                PassengerDL.updatePassenger(p, p);
                Passenger passenger = new Passenger(p.Name, rdBtnGood.Text);
                PassengerDL.addreviewintolist(passenger);
                PassengerDL.storeReviewsofPassengers("Feedbacks.txt", passenger);
                PassengerDL.storeallPassengersData("Passengers.txt");
                MessageBox.Show("Added");
            }

            else if(rdbtnSatisfactory.Checked)
            {
                p.Review = rdbtnSatisfactory.Text;
                PassengerDL.updatePassenger(p, p);
                Passenger passenger = new Passenger(p.Name, rdbtnSatisfactory.Text);
                PassengerDL.addreviewintolist(passenger);
                PassengerDL.storeallPassengersData("Passengers.txt");
                PassengerDL.storeReviewsofPassengers("Feedbacks.txt", passenger);
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Add your Feedback");
            }
        }
      
    }
}
