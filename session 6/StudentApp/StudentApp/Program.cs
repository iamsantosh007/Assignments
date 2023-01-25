using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Models;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student();
            student.Name = "sps";
            student.RollNo= 33;
            student.CGPA = 7.53f;
            float percentageOfStudent = student.GetPercentage(student.CGPA);
            Console.WriteLine($"The name is {student.Name} and roll number is {student.RollNo} and percentage is {percentageOfStudent}");
        }
    }
}
