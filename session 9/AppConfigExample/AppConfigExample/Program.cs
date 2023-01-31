using AppConfigExample.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppConfig appConfig=new AppConfig();
            Console.WriteLine("server name for connection one:-");
            appConfig.ConnectionOne();
            Console.WriteLine();
            Console.WriteLine("server name for connection two:-");
            appConfig.ConnectionTwo();  

            //Console.WriteLine("connection details for one"+connectionOne);
            //Console.WriteLine();
            //Console.WriteLine("connection details for Two"+connectionTwo);
        }

        

        
    }
}
