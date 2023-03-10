using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionCoreLib.HighLevelModule
{
    public interface IErrorTypeLogger
    {
        void Log(Exception ex);
    }
}
