using AxisBankConsoleApp.RatePolicy;
using FixedDepositryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositeTestCase.UnitTestCases
{
    [TestClass]
    public class RatePolicyTestClass
    {
        [TestMethod]
        public void ShouldReturn_8_5_For_DiwaliRate()
        {
            double expectedRate = 8.5;
            FixedDeposite deposite = new FixedDeposite(1,"santosh",50000,15,new DiwaliRatePolicy());
            Assert.AreEqual(expectedRate, deposite.RatePolicy.CalculateRate());
        }

        [TestMethod]
        public void ShouldReturn_5_6_For_HoliRate()
        {
            double expectedRate = 5.6;
            FixedDeposite deposite = new FixedDeposite(1, "santosh", 50000, 15, new HoliRatePolicy());
            Assert.AreEqual(expectedRate, deposite.RatePolicy.CalculateRate());
        }

        [TestMethod]
        public void ShouldReturn_5_2_For_NewYearRate()
        {
            double expectedRate =5.2;
            FixedDeposite deposite = new FixedDeposite(1, "santosh", 50000, 15, new NewYearRatePolicy());
            Assert.AreEqual(expectedRate, deposite.RatePolicy.CalculateRate());
        }
        [TestMethod]
        public void ShouldReturn_7_For_NoFestivalRate()
        {
            double expectedRate = 7;
            FixedDeposite deposite = new FixedDeposite(1, "santosh", 50000, 15, new NoFestivalRatePolicy());
            Assert.AreEqual(expectedRate, deposite.RatePolicy.CalculateRate());
        }


    }
}
