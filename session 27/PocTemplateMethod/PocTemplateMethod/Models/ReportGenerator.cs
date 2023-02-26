using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocTemplateMethod.Models
{
    public class ReportGenerator
    {

        public void GenerateReport()
        {
            RetrieveData();
            FormatData();
            PrintOutput();
            
        }

        public virtual void RetrieveData()
        {
            Console.WriteLine("Retrieve data started successfull");
        }

        public virtual void FormatData()
        {
            Console.WriteLine("Format data started successfull");
        }

        public virtual void PrintOutput()
        {
            Console.WriteLine("Print data started successfull");
        }
    }

}
