using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleRent;

namespace Unit_Test_Project
{
    [TestClass]
    public class UnitTest1
    {
        PerDayRental rent = new PerDayRental();
        //testing PerDayRental.cs

        [TestMethod]
        public void Test1()
        {
            //testing correct input. with an input of 3 days, the expected output should be 300.
            int days = 3;
            int expected = 300;


            rent.addDays(days);

            Assert.AreEqual(expected, rent.getCost());
        }
        [TestMethod]
        public void Test2()
        {
            //testing incorrect data.
            int days = -1;
            int expected = 0;

            rent.addDays(days);

            Assert.AreEqual(expected, rent.getCost());
        }

    }
}
