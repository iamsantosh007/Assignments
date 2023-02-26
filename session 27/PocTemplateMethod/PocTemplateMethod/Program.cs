using PocTemplateMethod.Models;

namespace PocTemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator report=new ReportGenerator();
            report.GenerateReport();
            Console.WriteLine();
            ReportGenerator pdfReport = new PDFReportGenerator();
            pdfReport.GenerateReport();
            

        }
    }
}