using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Class Commercial inherited from Customerm
 * Author: Dhaval Shah
 * When: Dec 2020
 */
namespace CustomerData
{
    public class Commercial:CustomerM
    {
        //base values for any Commercial power bill calculation
        public int CBASE = 60;
        public decimal C_RATE_P_KWH = 0.045m;
        public int C_INITKWH = 1000;
        // static values for statistic update
        public static int TotalCcust=0;
        public static decimal TotalCcharge = 0;
        /// <summary>
        /// constructor for Commercial
        /// </summary>
        /// <param name="a">Account num</param>
        /// <param name="b">name</param>
        /// <param name="c">type</param>
        public Commercial(string a = "0000000", string b = "XYZ", string c = "R")
        {
        }
        /// <summary>
        /// Claculate ower bill for Residential customer
        /// </summary>
        /// <param name="kwh">kwh used</param>
        /// <param name="pick">this will be 0 in this case</param>
        /// <param name="off">this will be 0 in this case</param>
        /// <returns>calculated charge</returns>
        public override decimal Calculate(int kwh, int pick = 0, int off = 0)
        {
            decimal a=0;
            if (kwh <= C_INITKWH)
            {
                a = CBASE;
            }
            else
            {
                a = CBASE + ((kwh - C_INITKWH) * C_RATE_P_KWH);
            }
            return a;
        }
    }
}
