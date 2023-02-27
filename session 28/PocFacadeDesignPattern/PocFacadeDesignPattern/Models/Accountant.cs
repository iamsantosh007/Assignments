using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocFacadeDesignPattern.Models
{
    public class Accountant
    {
        private LabWorker _labworker;
        private Professor _professor;
        public Accountant() 
        { 
            _labworker= new LabWorker();
            _professor= new Professor();
        }

        public void ShowPerDaySalaryOfLabworkerAndProfessor()
        {
            Console.WriteLine("The Labworker per day salary "+Labworker.PerDaySalary);
            Console.WriteLine("The professor per day salary "+Professor.PerDaySalary);

        }

        public LabWorker Labworker { get { return _labworker; } }

        public Professor Professor { get { return _professor; } }
    }
}
