using System;
using CustomerData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * unit test class for Commercial Customer
 * Author: Dhaval Shah
 * When: Dec 2020
 */
namespace Testcalculate
{
    [TestClass]
    public class CommercialTest
    {
        //if kwh is less then base kwh or zero
        [TestMethod]
        public void iflessthenINITkwh()
        {
            //Arrange
            decimal expectedCharge = 60;
            decimal actualCharge;
            int testkWh = 0;
            Commercial c;

            //Act
            c = new Commercial("testCommercialCustomer");
            actualCharge = c.Calculate(testkWh, 0, 0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        [TestMethod]
        public void ifMorethenINITkwh()
        {
            //Arrange
            decimal expectedCharge = 60.45m;
            decimal actualCharge;
            int testkWh = 1010;
            Commercial c;

            //Act
            c = new Commercial("testCommercialCustomer");
            actualCharge = c.Calculate(testkWh, 0, 0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}
