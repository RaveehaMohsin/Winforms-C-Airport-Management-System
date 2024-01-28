
namespace GUI__Business_Project_Airport__Final
{
    partial class PassengerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAirlines = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.ChangeScreen = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcomePassenger = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ChangeScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChangeScreen, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblExit, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblInfo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAirlines, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBooking, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblFeedback, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.01949F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.61988F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.78641F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.75728F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62136F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.17476F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(164, 437);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Luggage";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExit.Location = new System.Drawing.Point(38, 399);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(88, 30);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "Back";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfo.Location = new System.Drawing.Point(45, 187);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 30);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // lblAirlines
            // 
            this.lblAirlines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAirlines.AutoSize = true;
            this.lblAirlines.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirlines.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAirlines.Location = new System.Drawing.Point(13, 131);
            this.lblAirlines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAirlines.Name = "lblAirlines";
            this.lblAirlines.Size = new System.Drawing.Size(137, 30);
            this.lblAirlines.TabIndex = 0;
            this.lblAirlines.Text = "AirLines";
            this.lblAirlines.Click += new System.EventHandler(this.lblAirlines_Click);
            // 
            // lblBooking
            // 
            this.lblBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBooking.Location = new System.Drawing.Point(16, 296);
            this.lblBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(131, 30);
            this.lblBooking.TabIndex = 3;
            this.lblBooking.Text = "booking";
            this.lblBooking.Click += new System.EventHandler(this.lblBooking_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFeedback.Location = new System.Drawing.Point(3, 349);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(157, 30);
            this.lblFeedback.TabIndex = 4;
            this.lblFeedback.Text = "FEEDBACK";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // ChangeScreen
            // 
            this.ChangeScreen.BackgroundImage = global::GUI__Business_Project_Airport__Final.Properties.Resources.PASSENGER;
            this.ChangeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeScreen.ColumnCount = 1;
            this.ChangeScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ChangeScreen.Controls.Add(this.lblWelcomePassenger, 0, 1);
            this.ChangeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeScreen.Location = new System.Drawing.Point(170, 2);
            this.ChangeScreen.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeScreen.Name = "ChangeScreen";
            this.ChangeScreen.RowCount = 2;
            this.ChangeScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.35754F));
            this.ChangeScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.ChangeScreen.Size = new System.Drawing.Size(671, 437);
            this.ChangeScreen.TabIndex = 1;
            // 
            // lblWelcomePassenger
            // 
            this.lblWelcomePassenger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcomePassenger.AutoSize = true;
            this.lblWelcomePassenger.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcomePassenger.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomePassenger.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcomePassenger.Location = new System.Drawing.Point(71, 356);
            this.lblWelcomePassenger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomePassenger.Name = "lblWelcomePassenger";
            this.lblWelcomePassenger.Size = new System.Drawing.Size(528, 36);
            this.lblWelcomePassenger.TabIndex = 0;
            this.lblWelcomePassenger.Text = "Welcome to Passenger Interface";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI__Business_Project_Airport__Final.Properties.Resources._495_4952535_create_digital_profile_icon_blue_user_profile_icon_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PassengerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PassengerInterface";
            this.ShowIcon = false;
            this.Text = "PassengerInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PassengerInterface_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ChangeScreen.ResumeLayout(false);
            this.ChangeScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAirlines;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TableLayoutPanel ChangeScreen;
        private System.Windows.Forms.Label lblWelcomePassenger;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}