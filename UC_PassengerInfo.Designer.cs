
namespace GUI__Business_Project_Airport__Final
{
    partial class UC_PassengerInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblAccPin = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.BtnAddress = new System.Windows.Forms.Button();
            this.lblFamily = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValidationLNamePass = new System.Windows.Forms.Label();
            this.lblValidationFnamePass = new System.Windows.Forms.Label();
            this.lblValidationEmailPass = new System.Windows.Forms.Label();
            this.lblValidationCNICPass = new System.Windows.Forms.Label();
            this.lblValidationPhonePass = new System.Windows.Forms.Label();
            this.lblValidationAccPinPass = new System.Windows.Forms.Label();
            this.numericUpDownFamily = new System.Windows.Forms.NumericUpDown();
            this.ChangeScreenInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFamily)).BeginInit();
            this.ChangeScreenInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChangeScreenInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 495);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 51);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(681, 392);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.lblFirstName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtName, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtLname, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtEmail, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtPhone, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtCNIC, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtPin, 4, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblLastName, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblEmail, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCNIC, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblAccPin, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblPhoneNo, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.BtnAddress, 5, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblFamily, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblValidationLNamePass, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblValidationFnamePass, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblValidationEmailPass, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblValidationCNICPass, 4, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblValidationPhonePass, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblValidationAccPinPass, 4, 6);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownFamily, 3, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(677, 388);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(122, 62);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(228, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(103, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLname.Location = new System.Drawing.Point(452, 62);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(103, 20);
            this.txtLname.TabIndex = 2;
            this.txtLname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(228, 158);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(103, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(228, 254);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(103, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtCNIC
            // 
            this.txtCNIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCNIC.Location = new System.Drawing.Point(452, 158);
            this.txtCNIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(103, 20);
            this.txtCNIC.TabIndex = 5;
            this.txtCNIC.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPin
            // 
            this.txtPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPin.Location = new System.Drawing.Point(452, 254);
            this.txtPin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(103, 20);
            this.txtPin.TabIndex = 6;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged_1);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(347, 62);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(143, 158);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblCNIC
            // 
            this.lblCNIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNIC.Location = new System.Drawing.Point(369, 158);
            this.lblCNIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(45, 20);
            this.lblCNIC.TabIndex = 9;
            this.lblCNIC.Text = "CNIC";
            // 
            // lblAccPin
            // 
            this.lblAccPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccPin.AutoSize = true;
            this.lblAccPin.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccPin.Location = new System.Drawing.Point(357, 254);
            this.lblAccPin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccPin.Name = "lblAccPin";
            this.lblAccPin.Size = new System.Drawing.Size(70, 20);
            this.lblAccPin.TabIndex = 10;
            this.lblAccPin.Text = "Acc. Pin";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(123, 254);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(89, 20);
            this.lblPhoneNo.TabIndex = 11;
            this.lblPhoneNo.Text = "Phone No.";
            // 
            // BtnAddress
            // 
            this.BtnAddress.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnAddress.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddress.Location = new System.Drawing.Point(562, 338);
            this.BtnAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddress.Name = "BtnAddress";
            this.BtnAddress.Size = new System.Drawing.Size(109, 44);
            this.BtnAddress.TabIndex = 12;
            this.BtnAddress.Text = "Address";
            this.BtnAddress.UseVisualStyleBackColor = false;
            this.BtnAddress.Click += new System.EventHandler(this.BtnAddress_Click);
            // 
            // lblFamily
            // 
            this.lblFamily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.Location = new System.Drawing.Point(237, 354);
            this.lblFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(86, 15);
            this.lblFamily.TabIndex = 13;
            this.lblFamily.Text = "Family Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(2, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblValidationLNamePass
            // 
            this.lblValidationLNamePass.AutoSize = true;
            this.lblValidationLNamePass.Location = new System.Drawing.Point(226, 96);
            this.lblValidationLNamePass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidationLNamePass.Name = "lblValidationLNamePass";
            this.lblValidationLNamePass.Size = new System.Drawing.Size(0, 13);
            this.lblValidationLNamePass.TabIndex = 16;
            // 
            // lblValidationFnamePass
            // 
            this.lblValidationFnamePass.AutoSize = true;
            this.lblValidationFnamePass.Location = new System.Drawing.Point(450, 96);
            this.lblValidationFnamePass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidationFnamePass.Name = "lblValidationFnamePass";
            this.lblValidationFnamePass.Size = new System.Drawing.Size(0, 13);
            this.lblValidationFnamePass.TabIndex = 17;
            // 
            // lblValidationEmailPass
            // 
            this.lblValidationEmailPass.AutoSize = true;
            this.lblValidationEmailPass.Location = new System.Drawing.Point(226, 192);
            this.lblValidationEmailPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidationEmailPass.Name = "lblValidationEmailPass";
            this.lblValidationEmailPass.Size = new System.Drawing.Size(0, 13);
            this.lblValidationEmailPass.TabIndex = 18;
            // 
            // lblValidationCNICPass
            // 
            this.lblValidationCNICPass.AutoSize = true;
            this.lblValidationCNICPass.Location = new System.Drawing.Point(450, 192);
            this.lblValidationCNICPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidationCNICPass.Name = "lblValidationCNICPass";
            this.lblValidationCNICPass.Size = new System.Drawing.Size(0, 13);
            this.lblValidationCNICPass.TabIndex = 19;
            // 
            // lblValidationPhonePass
            // 
            this.lblValidationPhonePass.AutoSize = true;
            this.lblValidationPhonePass.Location = new System.Drawing.Point(226, 288);
            this.lblValidationPhonePass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidationPhonePass.Name = "lblValidationPhonePass";
            this.lblValidationPhonePass.Size = new System.Drawing.Size(0, 13);
            this.lblValidationPhonePass.TabIndex = 20;
            // 
            // lblValidationAccPinPass
            // 
            this.lblValidationAccPinPass.AutoSize = true;
            this.lblValidationAccPinPass.Location = new System.Drawing.Point(450, 288);
            this.lblValidationAccPinPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidationAccPinPass.Name = "lblValidationAccPinPass";
            this.lblValidationAccPinPass.Size = new System.Drawing.Size(0, 13);
            this.lblValidationAccPinPass.TabIndex = 21;
            // 
            // numericUpDownFamily
            // 
            this.numericUpDownFamily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownFamily.Location = new System.Drawing.Point(347, 352);
            this.numericUpDownFamily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownFamily.Name = "numericUpDownFamily";
            this.numericUpDownFamily.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownFamily.TabIndex = 22;
            // 
            // ChangeScreenInfo
            // 
            this.ChangeScreenInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChangeScreenInfo.ColumnCount = 1;
            this.ChangeScreenInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ChangeScreenInfo.Controls.Add(this.lblPersonalInfo, 0, 0);
            this.ChangeScreenInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeScreenInfo.Location = new System.Drawing.Point(2, 2);
            this.ChangeScreenInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeScreenInfo.Name = "ChangeScreenInfo";
            this.ChangeScreenInfo.RowCount = 1;
            this.ChangeScreenInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ChangeScreenInfo.Size = new System.Drawing.Size(681, 45);
            this.ChangeScreenInfo.TabIndex = 2;
            this.ChangeScreenInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.BackColor = System.Drawing.Color.Tan;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPersonalInfo.Location = new System.Drawing.Point(178, 3);
            this.lblPersonalInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(325, 38);
            this.lblPersonalInfo.TabIndex = 1;
            this.lblPersonalInfo.Text = "Personal Details";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 447);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(681, 46);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // UC_PassengerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_PassengerInfo";
            this.Size = new System.Drawing.Size(685, 495);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFamily)).EndInit();
            this.ChangeScreenInfo.ResumeLayout(false);
            this.ChangeScreenInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblAccPin;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Button BtnAddress;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblValidationLNamePass;
        private System.Windows.Forms.Label lblValidationFnamePass;
        private System.Windows.Forms.Label lblValidationEmailPass;
        private System.Windows.Forms.Label lblValidationCNICPass;
        private System.Windows.Forms.Label lblValidationPhonePass;
        private System.Windows.Forms.Label lblValidationAccPinPass;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownFamily;
        private System.Windows.Forms.TableLayoutPanel ChangeScreenInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}
