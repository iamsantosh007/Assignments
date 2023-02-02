using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadingContentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Content from Xml file:-");
            CaseStudyOneReadingFromXml();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Reading Content from html file:-");
            CaseStudyOneReadingFromHtml();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Reading Content from Text file:-");
            CaseStudyOneReadingFromTxt();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

        }

        private static void CaseStudyOneReadingFromTxt()
        {
            FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 10\\text.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            Console.WriteLine(data);
            stream.Close();
        }

        private static void CaseStudyOneReadingFromHtml()
        {
            FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 10\\Hello.html", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            Console.WriteLine(data);
            stream.Close();
        }

        private static void CaseStudyOneReadingFromXml()
        {
            FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 10\\note.xml", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            Console.WriteLine(data);
            stream.Close();
        }
    }
}
