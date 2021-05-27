using System;
using CustomerData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
 * unit test class for Industrial Customer
 * Author: Dhaval Shah
 * When: Dec 2020
 */
namespace Testcalculate
{
    [TestClass]
    public class IndustrialTest
    {
        //if pick kwh and off pick kwh both less then base kwh or zero
        [TestMethod]
        public void ifbothzeroORlessthenINIT()
        {
            //Arrange
            decimal expectedCharge = 116;
            decimal actualCharge;
            Industrial I;

            //Act
            I = new Industrial("testIndustrialCustomer");
            actualCharge = I.Calculate(0,0,0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        //if pick kwh less then base kwh or zero
        [TestMethod]
        public void ifpickzeroORlessthenINIT()
        {
            //Arrange
            decimal expectedCharge = 118.80m;
            decimal actualCharge;
            int kwhoff = 1100;
            Industrial I;

            //Act
            I = new Industrial("testIndustrialCustomer");
            actualCharge = I.Calculate(0, 0,kwhoff);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        //if off pick kwh less then base kwh or zero
        [TestMethod]
        public void ifoffzeroORlessthenINIT()
        {
            //Arrange
            decimal expectedCharge = 122.50m;
            decimal actualCharge;
            int kwhpick = 1100;
            Industrial I;

            //Act
            I = new Industrial("testIndustrialCustomer");
            actualCharge = I.Calculate(0, kwhpick,0);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        //if pick kwh and off pick both more then base kwh
        [TestMethod]
        public void ifbothmorethenINIT()
        {
            //Arrange
            decimal expectedCharge = 125.30m;
            decimal actualCharge;
            int kwhpick = 1100;
            int kwhoff = 1100;
            Industrial I;

            //Act
            I = new Industrial("testIndustrialCustomer");
            actualCharge = I.Calculate(0, kwhpick, kwhoff);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}
