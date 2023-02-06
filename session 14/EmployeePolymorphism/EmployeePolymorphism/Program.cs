using EmployeePolymorphism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Developer(101,"santosh",50000);
            var employee2=new ProjectManager(102,"patro",60000);
            var employee3=new QaTester(103,"Anand",30000);

            PrintDetails(employee);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            PrintDetails(employee2);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            PrintDetails(employee3);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        private static void PrintDetails(Employee employee)
        {
            
            Console.WriteLine($"The id is {employee.Id}\n" +
                $"The name is {employee.Name}\n" +
                $"The Basic salary is {employee.Basics}\n" +
                $"The Annual salary is {employee.AnnualCTC()}\n" +
                $"The Role of Employee is {employee.Role}");
            Console.WriteLine();
            employee.SalaryBreakup();
           

        }
    }
}
