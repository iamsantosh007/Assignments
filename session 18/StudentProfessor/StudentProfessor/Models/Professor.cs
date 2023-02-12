using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessor.Models
{
    class Professor:Person
    {
        private const int _perHourSalary=2;
        private int _day;
        public Professor(int id , string address, int dob, int day) : base(id, address, dob)
        {
            this._day = day;
        }

        public int PerHourSalary { get { return _perHourSalary; } }

        public int Day { 
            
            
            get { return _day; }
            
        
        }


        public int CalculateSalary()
        {
            return (this._day * PerHourSalary*1000);
        }

    }
}
