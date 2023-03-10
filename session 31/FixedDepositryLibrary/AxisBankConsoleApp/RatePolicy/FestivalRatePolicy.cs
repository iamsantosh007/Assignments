using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankConsoleApp.RatePolicy
{
    public class FestivalRatePolicy
    {
        public static double DiwaliRatePolicy()
        {
            return 8.5;
        }
        public static double HoliRatePolicy()
        {
            return 5.6;
        }
        public static double NewYearRatePolicy()
        {
            return 5.2;
        }
        public static double NoFestivalRatePolicy()
        {
            return 7.0;
        }
    }
}
