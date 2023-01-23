using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    class Program
    {
        public static void PrintSum(params int[] num)
        {
            string count = num.Length > 5 ? "you enter above than 5 number" : "";
            int sum = 0;
            foreach (int i in num)
            {
                sum+= i;
            }
            if(count!=null)
                Console.WriteLine(count);
            Console.WriteLine($"The sum of number is {sum}");

        }
        static void Main(string[] args)
        {
            PrintSum(5, 7, 8);
            Console.ReadLine();
        }
    }
}
