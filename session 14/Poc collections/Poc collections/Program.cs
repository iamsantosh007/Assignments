using Poc_collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudyOneList();
            Console.WriteLine();
            CaseStudyOneSet();
            Console.WriteLine();
            CaseStudyOneDictionary();
        }

        private static void CaseStudyOneDictionary()
        {
            Student stud1 = new Student(1, "santosh", 22);
            Student stud2 = new Student(2, "patro", 23);
            Dictionary<int,Student> keyValuePairs= new Dictionary<int,Student>();
            keyValuePairs.Add(1, stud1);
            keyValuePairs.Add(2, stud2);

            Student student = null;
            keyValuePairs.TryGetValue(2, out student);

            Console.WriteLine($"Id is {student.Id} name is {student.Name} and age is {student.Age}");
        }

        private static void CaseStudyOneSet()
        {
            Student stud1 = new Student(1, "santosh", 22);
            Student stud2 = new Student(2, "patro", 23);
            HashSet<Student> set = new HashSet<Student>();
            set.Add(stud1);
            set.Add(stud2);
            set.Add(stud1);

            foreach(var student in set)
            {
                Console.WriteLine($"Id is {student.Id} name is {student.Name} and age is {student.Age}");
            }
        }

        private static void CaseStudyOneList()
        {
           List<Student> students = new List<Student>();
           Student stud1=new Student(1,"santosh",22);
            Student stud2 = new Student(2, "patro", 23);
            students.Add(stud1);
            students.Add(stud2);
            foreach(var student in students) 
            {
                Console.WriteLine($"Id is {student.Id} name is {student.Name} and age is {student.Age}");
            }
        }
    }
}
