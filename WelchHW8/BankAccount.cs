using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelchHW8
{
    public class BankAccount
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string email;
        private string phoneNumber;
        private double balance;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if(value.IndexOf('@') == -1)
                {
                    email = "your@email.CompareTo";
                }
                else
                {
                    email = value;
                }
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount()
        {
            FirstName = "";
            LastName = "";
            Address = "";
            City = "";
            State = "";
            ZipCode = "";
            Email = "";
            PhoneNumber = "";
            Balance = 0;
        }

        public BankAccount(string firstName, string lastName, string address, string city, string state, string zipCode, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            Email = email;
            PhoneNumber = phoneNumber;
            Balance = 0;
        }

        public string FullAddress()
        {
            return String.Format("{0}\n{1}, {2} {3}", Address, City, State, ZipCode);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return String.Format("Account holder: {0} {1}\nAddress: {2}\nEmail: {3}\nPhone number: {4}\nAccount Balance {5}", FirstName, LastName, FullAddress(), Email, PhoneNumber, Balance.ToString());
        }

    }
}
