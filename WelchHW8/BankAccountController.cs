﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelchHW8
{
    public class BankAccountController
    {
        private List<BankAccount> accounts;

        public BankAccountController()
        {
            accounts = null;
        }
        public BankAccountController(List<BankAccount> accounts)
        {
            this.accounts = accounts;
        }

        public void AddAccount(string firstName, string lastName, string address, string city, string state, string zipCode, string email, string phoneNumber)
        {
            BankAccount bankAccount = new BankAccount(firstName, lastName, address, city, state, zipCode, email, phoneNumber);
            accounts.Add(bankAccount);
        }

        public string GetAccountsAsString()
        {
            string list = "";
            foreach (BankAccount account in accounts)
            {
                list = list + account + "\n";
            }
            return list;
        }
        public List<string> GetAccountHolderNames()
        {
            List<string> nameList = new List<string>();
            foreach(BankAccount account in accounts)
            {
                nameList.Add((account.FirstName + " " + account.LastName).Trim());
            }
            return nameList;
        }

    }
}