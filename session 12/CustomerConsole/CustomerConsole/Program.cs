using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerClassLibrary.Models;
namespace CustomerConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer=new Customer("santosg",24);
            Console.WriteLine($"Name is {customer.Name} and age is {customer.Age}");
        }
    }
}
