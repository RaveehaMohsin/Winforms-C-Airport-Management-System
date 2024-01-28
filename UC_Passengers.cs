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
    public partial class UC_Passengers : UserControl
    {
        public UC_Passengers()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
