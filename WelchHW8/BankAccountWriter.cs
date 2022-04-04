using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WelchHW8
{
    public class BankAccountWriter
    {
        public static bool WriteAccountsToFile(string fname, List<BankAccount> accounts)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fname, false))
                {
                    foreach (BankAccount account in accounts)
                    {
                        sw.WriteLine(account.ToTabDelimitedString());
                    }
                    sw.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
