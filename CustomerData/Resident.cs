using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Class Resident inherited from Customerm
 * Author: Dhaval Shah
 * When: Dec 2020
 */

namespace CustomerData
{
    public class Resident : CustomerM
    {
        //base values for any residential power bill calculation
        public int RBASE = 6;
        public decimal R_RATE_P_KWH = 0.052m;
        // static values for statistic update
        public static int TotalRcust=0;
        public static decimal TotalRcharge = 0;
        
       /// <summary>
       /// constructor for Resident
       /// </summary>
       /// <param name="a">Account num</param>
       /// <param name="b">name</param>
       /// <param name="c">type</param>
        public Resident(string a = "0000000", string b = "XYZ", string c = "R")
        {
        }
        /// <summary>
        /// Claculate ower bill for Residential customer
        /// </summary>
        /// <param name="kwh">kwh used</param>
        /// <param name="pick">this will be 0 in this case</param>
        /// <param name="off">this will be 0 in this case</param>
        /// <returns>calculated charge</returns>
        public override decimal Calculate(int kwh, int pick, int off)
        {
            decimal a=0;
            a = RBASE + (kwh * R_RATE_P_KWH);
            return a;
        }
    }
}
