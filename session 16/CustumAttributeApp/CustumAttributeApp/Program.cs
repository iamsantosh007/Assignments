using CustumAttributeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustumAttributeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employee=new Employee(101,"santosh");
            var student=new Student(102,"Ravi");
            var typeEmployee=typeof(Employee);
            var typeStudent=typeof(Student);

            RefectorChecker(typeEmployee,employee);
            Console.WriteLine();
            RefectorChecker(typeStudent,student);
            Console.WriteLine();
        }

        private static void RefectorChecker(Type type,object obj)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                
                if (method.IsDefined(typeof(RefectoredAttribute)))
                {
                    
                    method.Invoke(obj,null);
                }


            }
        }

        
    }
}
