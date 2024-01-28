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
    public partial class UC_FeedbackView : UserControl
    {
        public UC_FeedbackView()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataBind(List<Passenger> passengers)
        {
            var displayList = passengers.Select(p => new {  p.Name, p.Review}).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;

            dataGridView1.Columns["Name"].HeaderText = "Passenger Name";
            dataGridView1.Columns["Review"].HeaderText = "Feedback";


            dataGridView1.Refresh();

        }

        private void UC_FeedbackView_Load(object sender, EventArgs e)
        {
            dataBind(PassengerDL.passengers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
