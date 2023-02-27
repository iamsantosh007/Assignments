using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocFacadeDesignPattern.Models
{
    public class HODAccount
    {
        static void Main()
        {
            Accountant accountant=new Accountant();
            accountant.ShowPerDaySalaryOfLabworkerAndProfessor();
        }
    }
}
