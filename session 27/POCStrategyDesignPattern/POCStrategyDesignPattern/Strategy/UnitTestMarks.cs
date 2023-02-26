using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Strategy
{
    internal class UnitTestMarks : IMarks
    {
        public int GetMarks()
        {
            return 20;
        }
    }
}
