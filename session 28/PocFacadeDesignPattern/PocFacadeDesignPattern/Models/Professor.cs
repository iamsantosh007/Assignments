using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocFacadeDesignPattern.Models
{
    public class Professor
    {
        private const int _perDaySalary = 10;

        public int PerDaySalary { get { return _perDaySalary; } }
    }
}
