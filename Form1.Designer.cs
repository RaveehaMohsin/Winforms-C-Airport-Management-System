
namespace GUI__Business_Project_Airport__Final
{
    partial class frmHomePage
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
            this.components = new System.ComponentModel.Container();
            this.MainInterface = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSignIN = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.ChangeScreen1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeScreen = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Datelbl = new System.Windows.Forms.Label();
            this.timebl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainInterface.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ChangeScreen1.SuspendLayout();
            this.ChangeScreen.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainInterface
            // 
            this.MainInterface.ColumnCount = 2;
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.MainInterface.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.MainInterface.Controls.Add(this.ChangeScreen1, 1, 0);
            this.MainInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainInterface.Location = new System.Drawing.Point(0, 0);
            this.MainInterface.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainInterface.Name = "MainInterface";
            this.MainInterface.RowCount = 1;
            this.MainInterface.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainInterface.Size = new System.Drawing.Size(856, 482);
            this.MainInterface.TabIndex = 0;
            this.MainInterface.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSignIN, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSignUp, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblExit, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.618F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.88285F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.82682F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.33616F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.16638F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(131, 478);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI__Business_Project_Airport__Final.Properties.Resources.plane;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSignIN
            // 
            this.lblSignIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignIN.AutoSize = true;
            this.lblSignIN.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSignIN.Location = new System.Drawing.Point(5, 149);
            this.lblSignIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIN.Name = "lblSignIN";
            this.lblSignIN.Size = new System.Drawing.Size(121, 34);
            this.lblSignIN.TabIndex = 1;
            this.lblSignIN.Text = "Sign In";
            this.lblSignIN.Click += new System.EventHandler(this.lblSignIN_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignUp.Location = new System.Drawing.Point(3, 242);
            this.lblSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(125, 32);
            this.lblSignUp.TabIndex = 2;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExit.Location = new System.Drawing.Point(23, 327);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(85, 34);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // ChangeScreen1
            // 
            this.ChangeScreen1.ColumnCount = 1;
            this.ChangeScreen1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChangeScreen1.Controls.Add(this.ChangeScreen, 0, 0);
            this.ChangeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeScreen1.Location = new System.Drawing.Point(137, 2);
            this.ChangeScreen1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeScreen1.Name = "ChangeScreen1";
            this.ChangeScreen1.RowCount = 1;
            this.ChangeScreen1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChangeScreen1.Size = new System.Drawing.Size(717, 478);
            this.ChangeScreen1.TabIndex = 1;
            this.ChangeScreen1.Paint += new System.Windows.Forms.PaintEventHandler(this.ChangeScreen1_Paint);
            // 
            // ChangeScreen
            // 
            this.ChangeScreen.BackgroundImage = global::GUI__Business_Project_Airport__Final.Properties.Resources.WhatsApp_Image_2023_07_26_at_12_31_39_PM;
            this.ChangeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeScreen.ColumnCount = 1;
            this.ChangeScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChangeScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.ChangeScreen.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.ChangeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeScreen.Location = new System.Drawing.Point(2, 2);
            this.ChangeScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeScreen.Name = "ChangeScreen";
            this.ChangeScreen.RowCount = 2;
            this.ChangeScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChangeScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.ChangeScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.ChangeScreen.Size = new System.Drawing.Size(713, 474);
            this.ChangeScreen.TabIndex = 0;
            this.ChangeScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.ChangeScreen_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Datelbl
            // 
            this.Datelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Datelbl.AutoSize = true;
            this.Datelbl.Enabled = false;
            this.Datelbl.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Datelbl.Location = new System.Drawing.Point(2, 10);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(62, 21);
            this.Datelbl.TabIndex = 3;
            this.Datelbl.Text = "DATE";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click_1);
            // 
            // timebl
            // 
            this.timebl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timebl.AutoSize = true;
            this.timebl.Enabled = false;
            this.timebl.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timebl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.timebl.Location = new System.Drawing.Point(645, 10);
            this.timebl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timebl.Name = "timebl";
            this.timebl.Size = new System.Drawing.Size(62, 21);
            this.timebl.TabIndex = 2;
            this.timebl.Text = "DATE";
            this.timebl.Click += new System.EventHandler(this.timebl_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.97501F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.02499F));
            this.tableLayoutPanel1.Controls.Add(this.timebl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Datelbl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 431);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 41);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(856, 482);
            this.Controls.Add(this.MainInterface);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHomePage";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.MainInterface.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ChangeScreen1.ResumeLayout(false);
            this.ChangeScreen.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainInterface;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSignIN;
        private System.Windows.Forms.TableLayoutPanel ChangeScreen1;
        private System.Windows.Forms.TableLayoutPanel ChangeScreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label timebl;
        private System.Windows.Forms.Label Datelbl;
    }
}

