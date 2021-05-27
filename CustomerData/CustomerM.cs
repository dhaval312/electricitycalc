using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Class CustomerM for the base functianality of every customer
 * Author: Dhaval Shah
 * When: Dec 2020
 */

namespace CustomerData
{
    public class CustomerM
    {   
        //data to assign with each customer
        public string AccountNo;
        public string CustomerName;
        public string CustomerType;
        public decimal ChargeAmount;
        // static values for statistic update
        public static int TotalCust = 0;
        public static decimal TotalCharge = 0;
        //static Account number for auto incrementing it with every new customer
        public static decimal AutoAccNO = 12000011;
        /// <summary>
        /// to store data in a format in file
        /// </summary>
        /// <returns></returns>
        public string ToFileString()
        {
            return AccountNo + "," + CustomerName + "," + CustomerType + "," + ChargeAmount.ToString();
        }
        /// <summary>
        /// to display data in a listbox
        /// </summary>
        /// <returns></returns>
        public string ToDisplay()
        {
            return "AccountNo:"+ AccountNo + "| Customer Name:" + CustomerName + "| Customer Type:" + CustomerType + "| Charged Amount:" + ChargeAmount.ToString();
        }
        /// <summary>
        /// constructor for CustomerM base class
        /// </summary>
        /// <param name="a">Account number</param>
        /// <param name="b">name</param>
        /// <param name="c">Customer tyoe</param>
        /// <param name="d">charge</param>
        public CustomerM(string a="0000000", string b="XYZ", string c="R",Decimal d= 1334)
        {
            AccountNo = a;
            CustomerName = b;
            CustomerType = c;
            ChargeAmount = d;
        }
        /// <summary>
        /// just override it in child classes
        /// </summary>
        /// <param name="kwh"></param>
        /// <param name="pick"></param>
        /// <param name="off"></param>
        /// <returns></returns>
        public virtual decimal Calculate(int kwh, int pick, int off)
        {
            return 0;
        }

    }
}
