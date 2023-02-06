using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Models
{
    public abstract class Employee
    {
        private int _id;
        private string _name;   
        protected double _basicSalary;
        protected string _role;

        public Employee(int id, string name, double basicSalary)
        {
            _id = id;
            _name = name;
            _basicSalary = basicSalary;
        }

        public Employee(int id,string name,double basicSalary,string role):this(id,name,basicSalary)
        {
            _role= role;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public double Basics { get { return _basicSalary; } }
        public string Role { get { return _role; } }


        public abstract double AnnualCTC();
        public abstract void SalaryBreakup();


    }
}
