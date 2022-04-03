using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelchHW8
{
    public partial class frmUserInformation : Form
    {
        private BankAccountController accountController;
        public frmUserInformation(BankAccountController accountController)
        {
            InitializeComponent();
            this.accountController = accountController;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtStreetAddress.Text;
            string city = txtCity.Text;
            string state = cmbState.Text;
            string zipCode = txtZIPCode.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            accountController.AddAccount(firstName, lastName, address, city, state, zipCode, email, phoneNumber);
            MessageBox.Show(accountController.GetAccountsAsString());
        }
    }
}
