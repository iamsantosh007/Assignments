using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Strategy
{
    internal class SemesterOneMarks : IMarks
    {
        public int GetMarks()
        {
            return 80;
        }
    }
}
