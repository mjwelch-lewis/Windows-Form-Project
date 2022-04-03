namespace WelchHW8
{
    partial class frmUserInformation
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
            this.gbIdentifiers = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZIPCode = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZIPCode = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbDepositWithdrawal = new System.Windows.Forms.GroupBox();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdrawal = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.gbIdentifiers.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbDepositWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIdentifiers
            // 
            this.gbIdentifiers.Controls.Add(this.btnCreateAccount);
            this.gbIdentifiers.Controls.Add(this.textBox2);
            this.gbIdentifiers.Controls.Add(this.lblPhoneNumber);
            this.gbIdentifiers.Controls.Add(this.textBox1);
            this.gbIdentifiers.Controls.Add(this.lblEmail);
            this.gbIdentifiers.Controls.Add(this.txtLastName);
            this.gbIdentifiers.Controls.Add(this.txtFirstName);
            this.gbIdentifiers.Controls.Add(this.gbAddress);
            this.gbIdentifiers.Controls.Add(this.lblLastName);
            this.gbIdentifiers.Controls.Add(this.lblFirstName);
            this.gbIdentifiers.Location = new System.Drawing.Point(25, 24);
            this.gbIdentifiers.Name = "gbIdentifiers";
            this.gbIdentifiers.Size = new System.Drawing.Size(324, 373);
            this.gbIdentifiers.TabIndex = 0;
            this.gbIdentifiers.TabStop = false;
            this.gbIdentifiers.Text = "Identifiers";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(18, 27);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(76, 13);
            this.lblStreetAddress.TabIndex = 2;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.cmbState);
            this.gbAddress.Controls.Add(this.txtZIPCode);
            this.gbAddress.Controls.Add(this.txtCity);
            this.gbAddress.Controls.Add(this.txtStreetAddress);
            this.gbAddress.Controls.Add(this.lblZIPCode);
            this.gbAddress.Controls.Add(this.lblState);
            this.gbAddress.Controls.Add(this.lblCity);
            this.gbAddress.Controls.Add(this.lblStreetAddress);
            this.gbAddress.Location = new System.Drawing.Point(23, 93);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(280, 145);
            this.gbAddress.TabIndex = 3;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(18, 54);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(18, 82);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // lblZIPCode
            // 
            this.lblZIPCode.AutoSize = true;
            this.lblZIPCode.Location = new System.Drawing.Point(18, 113);
            this.lblZIPCode.Name = "lblZIPCode";
            this.lblZIPCode.Size = new System.Drawing.Size(52, 13);
            this.lblZIPCode.TabIndex = 5;
            this.lblZIPCode.Text = "ZIP Code";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(135, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(112, 24);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(151, 20);
            this.txtStreetAddress.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(112, 51);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtZIPCode
            // 
            this.txtZIPCode.Location = new System.Drawing.Point(112, 110);
            this.txtZIPCode.Name = "txtZIPCode";
            this.txtZIPCode.Size = new System.Drawing.Size(151, 20);
            this.txtZIPCode.TabIndex = 8;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cmbState.Location = new System.Drawing.Point(112, 79);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(151, 21);
            this.cmbState.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 255);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 285);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 9;
            // 
            // gbDepositWithdrawal
            // 
            this.gbDepositWithdrawal.Controls.Add(this.btnApprove);
            this.gbDepositWithdrawal.Controls.Add(this.textBox3);
            this.gbDepositWithdrawal.Controls.Add(this.lblAmount);
            this.gbDepositWithdrawal.Controls.Add(this.rbWithdrawal);
            this.gbDepositWithdrawal.Controls.Add(this.rbDeposit);
            this.gbDepositWithdrawal.Location = new System.Drawing.Point(402, 24);
            this.gbDepositWithdrawal.Name = "gbDepositWithdrawal";
            this.gbDepositWithdrawal.Size = new System.Drawing.Size(258, 152);
            this.gbDepositWithdrawal.TabIndex = 2;
            this.gbDepositWithdrawal.TabStop = false;
            this.gbDepositWithdrawal.Text = "Deposit/Withdrawal";
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(28, 27);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(61, 17);
            this.rbDeposit.TabIndex = 0;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbWithdrawal
            // 
            this.rbWithdrawal.AutoSize = true;
            this.rbWithdrawal.Location = new System.Drawing.Point(133, 27);
            this.rbWithdrawal.Name = "rbWithdrawal";
            this.rbWithdrawal.Size = new System.Drawing.Size(70, 17);
            this.rbWithdrawal.TabIndex = 1;
            this.rbWithdrawal.TabStop = true;
            this.rbWithdrawal.Text = "Withdraw";
            this.rbWithdrawal.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(25, 69);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 10;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(108, 328);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(111, 23);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(28, 110);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(213, 23);
            this.btnApprove.TabIndex = 11;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // frmUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 416);
            this.Controls.Add(this.gbDepositWithdrawal);
            this.Controls.Add(this.gbIdentifiers);
            this.Name = "frmUserInformation";
            this.Text = "User Information";
            this.gbIdentifiers.ResumeLayout(false);
            this.gbIdentifiers.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbDepositWithdrawal.ResumeLayout(false);
            this.gbDepositWithdrawal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIdentifiers;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtZIPCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblZIPCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.GroupBox gbDepositWithdrawal;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.RadioButton rbWithdrawal;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.Button btnApprove;
    }
}

