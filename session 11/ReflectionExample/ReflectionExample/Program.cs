using ReflectionExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflecter reflecter = new Reflecter(10);
            ShowDetails(reflecter);
        }

        private static void ShowDetails(Object obj)
        {
            Type type= obj.GetType();
            Console.WriteLine($"The type of class is {type.Name}");
            MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly|BindingFlags.Instance|BindingFlags.Public);
            Console.WriteLine($"There is total Methods {methods.Length} see below:-");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine($"There is total Constructor {constructors.Length}");
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("There is total "+properties.Length+" Property");
        }
    }
}
