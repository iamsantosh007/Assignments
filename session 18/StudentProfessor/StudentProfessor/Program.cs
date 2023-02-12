using StudentProfessor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person student = new Student(101,"boisar",10-11-1999,branches.MCA);
            //Console.WriteLine($"_id is {student.Id} _address is {student.Address} _branch is {((Student)student).PrintDetails()}");
            //Console.WriteLine("----------------------------------------------------------------------");

            //Person professor = new Professor(102,"palghar",10-89-52,30);
            //int day=((Professor)professor).Day;
            //Console.WriteLine($"_id is {professor.Id} _address is {professor.Address} and salary is {((Professor)professor).CalculateSalary(day)}");
            //Console.ReadLine(); 

            Student student= new Student(101, "boisar", 10 - 11 - 1999, branches.MCA);
            Console.WriteLine($"id is {student.Id} and the address is {student.Address} and the _branch is {student.Branch}");
            Console.WriteLine("------------------------------------------------------------------------");

            Professor professor= new Professor(102, "palghar", 10 - 89 - 52, 30);
            Console.WriteLine($"Id is {professor.Id} and the address is {professor.Address} and the salary is {professor.CalculateSalary()}");


        }

    }
}
