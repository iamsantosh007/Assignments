using EvenOddApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenOdd evenOdd = new EvenOdd(); 
            Console.WriteLine("enter the range for Even And Odd");
            int range=Convert.ToInt32(Console.ReadLine());
            evenOdd.EvenNumGenerator(range);
            evenOdd.OddNumGenerator(range);
            Console.WriteLine("Even number for range "+range);
            foreach(int i in evenOdd.EvenNum)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("odd num for range "+range);
            foreach(int i in evenOdd.OddNum)
            {
                Console.WriteLine(i);
            }

        }
    }
}
