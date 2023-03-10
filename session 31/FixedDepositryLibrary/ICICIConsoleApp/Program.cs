using FixedDepositryLibrary;
using ICICIConsoleApp.Models;

namespace ICICIConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuaterOneRatePolicy policy = new QuaterOneRatePolicy();
            FixedDeposite deposite = new FixedDeposite(101,"patro",4123,15,policy);
            Console.WriteLine("The Simple intrest is"+deposite.CalculateSimpleIntrest());
        }
    }
}