using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionConsoleApp.LowLevelModule
{
    public class ErroTypes
    {
        public static void DBLogger(Exception ex)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Logging error details in database");
            Console.WriteLine(ex.Message.ToUpper());
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }

        public static void FileLogger(Exception ex)
        {
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("Logging error details in File");
            Console.WriteLine(ex.Message.ToUpper());
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
