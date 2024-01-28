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
    public partial class UC_LuggageView : UserControl
    {
        public UC_LuggageView()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_LuggageView_Load(object sender, EventArgs e)
        {
            dataBind(PassengerDL.passengers);
        }


        public void dataBind(List<Passenger> passengers)
        {

            var displayList = passengers.Select(p => new {  p.Name , LuggageType = p.Passengerluggage.Luggagetype , LuggageWeight = p.Passengerluggage.Luggageweight  , LuggageID = p.Passengerluggage.LuggageID}).ToList();
            dataGridViewLuggages.DataSource = null;
            dataGridViewLuggages.DataSource = displayList;

            dataGridViewLuggages.Columns["Name"].HeaderText = "Passenger Name";
            dataGridViewLuggages.Columns["LuggageType"].HeaderText = "Luggage Type";
            dataGridViewLuggages.Columns["LuggageWeight"].HeaderText = "Luggage Weight";
            dataGridViewLuggages.Columns["LuggageID"].HeaderText = "Luggage ID";
            

            dataGridViewLuggages.Refresh();



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
