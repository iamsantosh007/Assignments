using FixedDepositryLibrary;
using FixedDepositryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxisBankConsoleApp.RatePolicy;

namespace FixedDepositeTestCase.UnitTestCases
{
    [TestClass]
    public class FixedDepositeTestCase
    {
        [TestMethod]
        public void Account_Created_With_4Parameters()
        {
            int expectedNumber = 101;
            string expectedName = "santosh";
            int expectedPrinciple = 50000;
            int expectedTenure = 15;
            DiwaliRatePolicy expectedRate = new DiwaliRatePolicy();
            FixedDeposite deposite = new FixedDeposite(expectedNumber,expectedName,expectedPrinciple,expectedTenure,expectedRate);
            Assert.AreEqual(expectedName,deposite.Name);
            Assert.AreEqual(expectedNumber, deposite.Id);
            Assert.AreEqual(expectedPrinciple,deposite.Principle);
            Assert.AreEqual(expectedTenure,deposite.Duration);

        }
        [TestMethod]
        public void CalculateRate_IS_Successfull()
        {
            double expectedRate = 8.5;
            FixedDeposite deposite = new FixedDeposite(101,"santosh",500, 10, new DiwaliRatePolicy());
            Assert.AreEqual(expectedRate,deposite.RatePolicy.CalculateRate());

        }
        [TestMethod]
        public void CalculateSimple_Intrest_Is_Successfull()
        {
            double expectedSimpeIntrest = 42500;
            FixedDeposite deposite = new FixedDeposite(101, "santosh", 500, 10, new DiwaliRatePolicy());
            Assert.AreEqual(expectedSimpeIntrest, deposite.CalculateSimpleIntrest());
        }

    }
}
