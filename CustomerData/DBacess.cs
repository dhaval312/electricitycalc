using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Class DBacess for storing and reading data from file
 * Author: Dhaval Shah
 * When: Dec 2020
 */
namespace CustomerData
{
    public class DBacess
    {
        //file path
        const string PATH = "..\\..\\cust.txt";
        /// <summary>
        /// to read customers from the file and save it in to a list 
        /// in addition it also udates the statistic values of every classes and account number
        /// </summary>
        /// <returns>list of customer</returns>
        public static List<CustomerM> GetCustomers()
        {
            List<CustomerM> customers = new List<CustomerM>();
            string line;
            string[] field;
            CustomerM newcust;
            using (StreamReader sr = new StreamReader(new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    field = line.Split(',');
                    try
                    {
                        newcust = new CustomerM
                        {
                            AccountNo = field[0],
                            CustomerName = field[1],
                            CustomerType = field[2],
                            ChargeAmount = Decimal.Parse(field[3]),
                        };
                    }
                    catch (Exception e)
                    {
                        newcust = new CustomerM
                        {
                           
                        };
                    }
                    CustomerM.TotalCust++;
                    CustomerM.AutoAccNO++;
                    CustomerM.TotalCharge = CustomerM.TotalCharge + newcust.ChargeAmount;
                    if (newcust.CustomerType == "R")
                    {
                        Resident.TotalRcust++;
                        Resident.TotalRcharge = Resident.TotalRcharge + newcust.ChargeAmount;
                    }
                    else if (newcust.CustomerType == "C")
                    {
                        Commercial.TotalCcust++;
                        Commercial.TotalCcharge = Commercial.TotalCcharge + newcust.ChargeAmount;
                    }
                    else
                    {
                        Industrial.TotalIcust++;
                        Industrial.TotalIcharge = Industrial.TotalIcharge + newcust.ChargeAmount;
                    }
                    customers.Add(newcust);
                   }
            }
            return customers;
        }
        /// <summary>
        /// to save new customr in file
        /// </summary>
        /// <param name="customers">list of new customer</param>
        public static void SaveCustomers(List<CustomerM> customers)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                foreach (CustomerM c in customers)
                {
                    sw.WriteLine(c.ToFileString());
                }
            }
        }
    }
}
