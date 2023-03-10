using AxisBankConsoleApp.RatePolicy;
using FixedDepositryLibrary;

namespace AxisBankConsoleApp
{
   
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            CaseStudyForHoly();
            CaseStudyForDiwali();
        }

        private static void CaseStudyForDiwali()
        {
            FixedDeposite fixedDeposite = new FixedDeposite(1, "sp", 50000, 7, new DFestival(FestivalRatePolicy.DiwaliRatePolicy));
            double simpleIntrest = fixedDeposite.CalculateSimpleIntrest();
            Console.WriteLine("The simple intrest is " + simpleIntrest);
        }

        private static void CaseStudyForHoly()
        {
            DFestival festival = FestivalRatePolicy.HoliRatePolicy;
            FixedDeposite fixedDeposite = new FixedDeposite(1, "sp", 50000, 7, festival);
            double simpleIntrest = fixedDeposite.CalculateSimpleIntrest();
            Console.WriteLine("The simple intrest is " + simpleIntrest);
        }
    }
}