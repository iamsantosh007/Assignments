using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocTemplateMethod.Models
{
    public class PDFReportGenerator:ReportGenerator
    {


        public override void RetrieveData()
        {
            Console.WriteLine("Data is retrieve successfull");
        }

        public override void FormatData()
        {
            Console.WriteLine("Data is format successfull");
        }

        public override void PrintOutput()
        {
            Console.WriteLine("Data is print successfull");
        }
    }

}
