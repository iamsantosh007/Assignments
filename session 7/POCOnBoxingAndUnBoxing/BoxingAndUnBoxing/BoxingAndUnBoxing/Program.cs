using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseBoxing();
            CaseUnBoxing();
        }

        public static void CaseBoxing()
        {
            int number = 2023;
            object obj = number;
            number = 100;
            System.Console.WriteLine
            ("Value - type value of num is : {0}", number);
            System.Console.WriteLine
            ("Object - type value of obj is : {0}", obj);
        }

        public static void CaseUnBoxing()
        {
            int number = 2023;
            object obj = number;
            int numberTwo = (int)obj;

           
            Console.WriteLine("Value -: {0}", numberTwo);
            Console.WriteLine("Object -: {0}", obj);

           

        }
    }
}
