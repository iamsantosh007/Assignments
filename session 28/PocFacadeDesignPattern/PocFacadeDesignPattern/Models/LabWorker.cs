using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocFacadeDesignPattern.Models
{
    public class LabWorker
    {
        private const int _perDaySalary=5;
        public int PerDaySalary { get { return _perDaySalary; } }
    }
}
