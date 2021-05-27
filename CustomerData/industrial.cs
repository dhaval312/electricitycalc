using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Class Industrial inherited from Customerm
 * Author: Dhaval Shah
 * When: Dec 2020
 */

namespace CustomerData
{
    public class Industrial:CustomerM
    {
        //base values for any Industrial power bill calculation
        public int IBASE_PEAK_HOUR = 76;
        public decimal I_RATE_PEAK_P_KWH = 0.065m;
        public int IBASE_OFF_HOUR = 40;
        public decimal I_RATE_OFF_P_KWH = 0.028m;
        public int I_INITKWH = 1000;
        // static values for statistic update
        public static int TotalIcust = 0;
        public static decimal TotalIcharge = 0;
        /// <summary>
        /// constructor for Industrial
        /// </summary>
        /// <param name="a">Account num</param>
        /// <param name="b">name</param>
        /// <param name="c">type</param>
        public Industrial(string a = "0000000", string b = "XYZ", string c = "R")
        {
        }
        /// <summary>
        /// Claculate ower bill for Residential customer
        /// </summary>
        /// <param name="kwh">this will be 0 in this case</param>
        /// <param name="pick">kwh used in pick hours</param>
        /// <param name="off">kwh used in off pick hours</param>
        /// <returns>calculated charge</returns>
        public override decimal Calculate(int kwh, int pick, int off)
        {
            decimal pickBill=0, offBill=0;
            if (pick <= 1000)
                pickBill = IBASE_PEAK_HOUR;
            else
                pickBill = IBASE_PEAK_HOUR + ((pick - I_INITKWH) * I_RATE_PEAK_P_KWH);

            if (off <= 1000)
                offBill = IBASE_OFF_HOUR;
            else
                offBill = IBASE_OFF_HOUR + ((off - I_INITKWH) * I_RATE_OFF_P_KWH);

             return(pickBill + offBill);
        }
    }
}
