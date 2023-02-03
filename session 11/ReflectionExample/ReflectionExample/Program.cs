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

            Type type = typeof(Reflecter);
            ShowDetails(type);

        }

        private static void ShowDetails(Type type)
        {
            
            Console.WriteLine($"The type of class is {type.Name}");
            Console.WriteLine();
            MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly|BindingFlags.Instance|BindingFlags.Public);
            Console.WriteLine($"There is total Methods {methods.Length} see below:-");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine($"There is total Constructor {constructors.Length}");
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
                
            }
            Console.WriteLine();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("There is total "+properties.Length+" Property");
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
                
            }
        }
    }
}
