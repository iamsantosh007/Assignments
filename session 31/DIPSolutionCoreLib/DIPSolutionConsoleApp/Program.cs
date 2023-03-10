
using DISPVoilationApp.Models;
using DIPSolutionConsoleApp.LowLevelModule;

namespace DIPSolutionConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            TaxCalculator calc=new TaxCalculator(new DErrorLoggerType(ErroTypes.DBLogger));
            calc.Calculate(1,0);

        }
    }
}