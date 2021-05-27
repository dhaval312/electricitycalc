using System;
using CustomerData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * unit test class for Residential Customer
 * Author: Dhaval Shah
 * When: Dec 2020
 */
namespace Testcalculate
{
    [TestClass]
    public class ResidentTest
    {
        //if kwh is zero
        [TestMethod]
        public void ifZerokwh()
        {
            //Arrange
            decimal expectedCharge = 6;
            decimal actualCharge;
            int testkWh = 0;
            Resident r;

            //Act
            r = new Resident("testResidentCustomer");
            actualCharge = r.Calculate(testkWh, 0, 0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        //if kwh is more then zero
        [TestMethod]
        public void ifNormalvalue()
        {
            //Arrange
            decimal expectedCharge = 6.52m;
            decimal actualCharge;
            int testkWh = 10;
            Resident r;

            //Act
            r = new Resident("testResidentCustomer");
            actualCharge = r.Calculate(testkWh, 0, 0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}
