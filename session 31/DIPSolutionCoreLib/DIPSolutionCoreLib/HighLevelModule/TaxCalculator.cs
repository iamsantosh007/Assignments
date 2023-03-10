using DIPSolutionCoreLib.HighLevelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISPVoilationApp.Models
{
    public delegate void DErrorLoggerType(Exception ex);
    public class TaxCalculator
    {
        private DErrorLoggerType _errorLoggerType;

        public TaxCalculator(DErrorLoggerType errorLoggerType)
        {
            _errorLoggerType = errorLoggerType;
        }

        public int Calculate(int income,int rate)
        {
            int result = -1;

            try
            {
                result = income / rate;
            }catch(Exception ex)
            {
                _errorLoggerType(ex);
            }
            return result;
        }
    }
}
