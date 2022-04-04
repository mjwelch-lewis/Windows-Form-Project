using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WelchHW8
{
    public class BankAccountReader
    {
        public static List<BankAccount> ReadCoursesFromFile(string fname)
        {
            try
            {
                List<BankAccount> accounts = new List<BankAccount>();
                string line;
                BankAccount account;
                string[] parts;
                using (StreamReader sr = new StreamReader(fname))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine().Trim();
                        parts = line.Split('\t');
                        accounts.Add(new BankAccount(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], Convert.ToDouble(parts[8])));
                    }
                    sr.Close();
                }
                return accounts;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
