using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustumAttributeV2.Models
{
    public class TestRunner
    {
        static void Main(string[] args)
        {
            var classA=new ClassA();
            Type type=typeof(ClassA);
            Run(type,classA);
        }

        private static void Run(Type type,object obj)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods) 
            {
                if (method.IsDefined(typeof(MethodLevelAttribute)))
                {

                    Console.WriteLine($"Method name {method.Name}");
                    Console.Write($"Method parameter is:-");
                    GetParameter(method);
                    Console.WriteLine();
                    object resultOfMethods=method.Invoke(obj, new object[] { 1, 2 });
                    Console.WriteLine("The Result of method is "+resultOfMethods);
                    Console.WriteLine();
                }
            }
        }

        private static void GetParameter(MethodInfo method)
        {
            ParameterInfo[] paraminfo = method.GetParameters();
            foreach (ParameterInfo param in paraminfo)
            {
                Console.Write(param+" ");
            }
        }
    }
}
