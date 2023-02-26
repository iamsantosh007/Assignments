using POCStrategyDesignPattern.Module;
using POCStrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Context
{
    internal class SchoolContest
    {
        static void Main()
        {
            School school= new School(new SemesterOneMarks());
            int marks=school.Marks.GetMarks();
            Console.WriteLine(marks);

            school=new School(new SemesterTwoMarks());
            marks = school.Marks.GetMarks();
            Console.WriteLine(marks);

            school = new School(new UnitTestMarks());
            marks = school.Marks.GetMarks();
            Console.WriteLine(marks);

        }

    }
}
