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
            LoadAccountsDropdown();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtStreetAddress.Text;
            string city = txtCity.Text;
            string state = cmbState.GetItemText(cmbState.SelectedItem);
            string zipCode = txtZIPCode.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            int index = accountController.Exists(firstName, lastName);
            if (index >= 0)
            {
                accountController.UpdateAccountInfo(firstName, lastName, address, city, state, zipCode, email, phoneNumber, index);
            }
            else
            {
                accountController.AddAccount(firstName, lastName, address, city, state, zipCode, email, phoneNumber);
            }
            LoadAccountsDropdown();
            ChooseAccountFromDropdown(firstName, lastName);
            MessageBox.Show(accountController.GetAccountsAsString());
        }
        private void LoadAccountsDropdown()
        {
            List<string> accountHolderNames = accountController.GetAccountHolderNames();
            cmbAccountHolderNames.DataSource = accountHolderNames;
            cmbAccountHolderNames.Refresh();
        }

        private void ChooseAccountFromDropdown(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            int index = cmbAccountHolderNames.Items.IndexOf(fullName);
            if(index >= 0)
            {
                cmbAccountHolderNames.SelectedIndex = index;
            }
            
        }

        private void cmbAccountHolderNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] name;
            Dictionary<string, string> data = new Dictionary<string, string>();
            if(cmbAccountHolderNames.SelectedIndex != -1)
            {
                name = cmbAccountHolderNames.GetItemText(cmbAccountHolderNames.SelectedItem).Split(' ');
                data = accountController.GetDataForAccountByName(name[0], name[1]);
                if(data != null)
                {
                    txtFirstName.Text = data["first name"];
                    txtLastName.Text = data["last name"];
                    txtStreetAddress.Text = data["address"];
                    txtCity.Text = data["city"];
                    cmbState.SelectedIndex = cmbState.Items.IndexOf(data["state"]);
                    txtZIPCode.Text = data["zip code"];
                    txtEmail.Text = data["email"];
                    txtPhoneNumber.Text = data["phone number"];
                }
            }
            Refresh();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.InitialDirectory = "C:\\temp";
            dlgOpen.Filter = "text files (*.txt)|*.txt|all files (*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;
            string fname;
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fname = dlgOpen.FileName;
                accountController.Load(fname);
            }
            LoadAccountsDropdown();
            Refresh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "C:\\temp";
            dlgSave.Filter = "text files (*.txt)|*.txt|all files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            string fname;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;
                accountController.Save(fname);
            }
            MessageBox.Show("Data Saved");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application demonstrates how to create Windows forms with controls, menus, and save/load dialog boxes.");
        }
    }
}
