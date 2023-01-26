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
            student.Name = "santosh patro";
            student.RollNo= 33;
            student.CGPA = 7.53f;
            float percentageOfStudent = student.GetPercentage(student.CGPA);
            student.PayFees(2000f);
            Console.WriteLine($"The name is {student.Name}\n roll number is {student.RollNo}\n percentage is {percentageOfStudent}\n her total fees is {student.TotalFees}\n he has remaining balance of {student.RemainingFees}\n");
            student.PayFees(3000f);
            Console.WriteLine($"The name is {student.Name}\n roll number is {student.RollNo}\n percentage is {percentageOfStudent}\n her total fees is {student.TotalFees}\n he has remaining balance of {student.RemainingFees}\n");
            student.PayFees(4000f);
            Console.WriteLine($"The name is {student.Name}\n roll number is {student.RollNo}\n percentage is {percentageOfStudent}\n her total fees is {student.TotalFees}\n he has remaining balance of {student.RemainingFees}\n");
        }
    }
}
