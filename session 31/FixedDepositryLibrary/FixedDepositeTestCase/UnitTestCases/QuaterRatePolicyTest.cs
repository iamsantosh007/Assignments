using AxisBankConsoleApp.RatePolicy;
using FixedDepositryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositeTestCase.UnitTestCases
{
    [TestClass]
    public class QuaterRatePolicyTest
    {
        [TestMethod]
        public void ShouldReturn_10_For_quate()
        {
            double expectedRate = 5.6;
            FixedDeposite deposite = new FixedDeposite(1, "santosh", 50000, 15, new HoliRatePolicy());
            Assert.AreEqual(expectedRate, deposite.RatePolicy.CalculateRate());
        }
    }
}
