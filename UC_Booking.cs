using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using OOP_BUSINESS_PROJECT_FINAL.BL;
using OOP_BUSINESS_PROJECT_FINAL.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI__Business_Project_Airport__Final
{
    public partial class UC_Booking : UserControl
    {
        Passenger p;
        public UC_Booking(Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Booking_Load(object sender, EventArgs e)
        {
            double taxPriceofTicket = 0;
            double totalAmount = 0;

            btnPdf.Enabled = false;

            lblValidationPin.Text = "Enter the Pin";
            lblValidationPin.ForeColor = Color.Green;

        

            for (int idx = 0; idx < PassengerDL.passengerFlights.Count; idx ++)
            {
                if (p.Passengerflight.FlightID == PassengerDL.passengerFlights[idx].FlightID)
                {
                   taxPriceofTicket = PassengerDL.passengerFlights[idx].calculateTax();
                   
                }
            }

            totalAmount = taxPriceofTicket * p.Amountofpeople;
            
           

            lblTicketPriceTxt.Text = p.Passengerflight.Bill_amount.ToString();
            lblTicketGstTxt.Text = taxPriceofTicket.ToString();
            lblTotalAmountTxt.Text = totalAmount.ToString();

        }

        

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            if(txtPin.Text == p.Pin.ToString())
            {
                lblValidationPin.Text = "Correct Pin";
                lblValidationPin.ForeColor = Color.Green;
                btnPdf.Enabled = true;
            }
            else if (txtPin.Text != p.Pin.ToString())
            {
                lblValidationPin.Text = "Incorrect Pin";
                lblValidationPin.ForeColor = Color.Red;
                btnPdf.Enabled = false;
            }
            
               
            
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket has been generated in Folder!");
            ExportToPDF();
        }

        public void ExportToPDF()  // generate receipt
        {

            //if (booking == 'y' || booking == 'Y')
            //{
                string Main = "Air Line Management System";
                string passsName = p.Name;
                string l = "Name of Passenger";
                string ticketno = p.Passengerflight.FlightID;
                string Flight = p.Passengerflight.Class_type;
                string From = p.Passengerflight.Current_location;
                string To = p.Passengerflight.Desired_location;
                p.Amountofpeople = p.Amountofpeople + 1;
                string Quanity = p.Amountofpeople.ToString();
                string Amount = p.Passengerflight.Bill_amount.ToString();

                Document document = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(document, new System.IO.FileStream(passsName + " Ticket.pdf", FileMode.Create));
                // passenger name ()

                document.Open();



                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance("airplane.jpeg");
                image.ScaleToFit(60, 50);
                float pageWidth = document.PageSize.Width;
                float x = (pageWidth - image.ScaledWidth) / 2;
                image.SetAbsolutePosition(x, 800);

                document.Add(image);

                iTextSharp.text.Font headingFont = FontFactory.GetFont("Times New Roman", 18, iTextSharp.text.Font.BOLD);
                Paragraph heading = new Paragraph(Main, headingFont);
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingBefore = 10f;
                heading.SpacingAfter = 10f;

                document.Add(heading);

                LineSeparator line = new LineSeparator();
                document.Add(line);


                iTextSharp.text.Font headingFont2 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading2 = new Paragraph(l + " :                                                                    " + passsName, headingFont2);// raveeha
                heading2.Alignment = Element.ALIGN_LEFT;
                heading2.SpacingBefore = 10f;
                heading2.SpacingAfter = 10f;

                document.Add(heading2);



                iTextSharp.text.Font headingFont3 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading3 = new Paragraph("Ticket No" + " :                                                                                    " + ticketno, headingFont3);
                heading3.Alignment = Element.ALIGN_LEFT;
                heading3.SpacingBefore = 10f;
                heading3.SpacingAfter = 10f;

                document.Add(heading3);

                iTextSharp.text.Font headingFont4 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading4 = new Paragraph("Flight Type" + " :                                                                                    " + Flight, headingFont4);
                heading4.Alignment = Element.ALIGN_LEFT;
                heading4.SpacingBefore = 10f;
                heading4.SpacingAfter = 10f;

                document.Add(heading4);


                iTextSharp.text.Font headingFont5 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading5 = new Paragraph("Current Location" + " :                                                                        " + From, headingFont4);
                heading5.Alignment = Element.ALIGN_LEFT;
                heading5.SpacingBefore = 10f;
                heading5.SpacingAfter = 10f;

                document.Add(heading5);

                iTextSharp.text.Font headingFont6 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading6 = new Paragraph("Desired Location" + " :                                                                         " + To, headingFont6);
                heading6.Alignment = Element.ALIGN_LEFT;
                heading6.SpacingBefore = 10f;
                heading6.SpacingAfter = 10f;

                document.Add(heading6);

                iTextSharp.text.Font headingFont7 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading7 = new Paragraph("Amount of Passengers" + " :                                                                         " + Quanity, headingFont7);
                heading7.Alignment = Element.ALIGN_LEFT;
                heading7.SpacingBefore = 10f;
                heading7.SpacingAfter = 10f;

                document.Add(heading7);

                iTextSharp.text.Font headingFont8 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading8 = new Paragraph("Biling Amount" + " :                                                                                " + Amount, headingFont7);
                heading8.Alignment = Element.ALIGN_LEFT;
                heading8.SpacingBefore = 10f;
                heading8.SpacingAfter = 10f;

                document.Add(heading8);


                document.Close();
            //}
           
        }
    }
}
