using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingContentApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing content in xml file:-");
            CaseStudyOneWritingInXml();
            Console.WriteLine("Writing Done");
            Console.WriteLine("------------------------");
            Console.WriteLine("Writing content in html file:-");
            CaseStudyOneWritingInHtml();
            Console.WriteLine("Writing Done");
            Console.WriteLine("------------------------");
            Console.WriteLine("Writing content in Text file:-");
            CaseStudyOneWritingInText();
            Console.WriteLine("Writing Done");
            Console.WriteLine("------------------------");

        }

        private static void CaseStudyOneWritingInText()
        {
            FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 10\\writeText.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("hello my name is santosh patro\n" +
                "I am persuing my mca degree");
            writer.Close();
            stream.Close();
        }

        private static void CaseStudyOneWritingInHtml()
        {
            FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 10\\writeHtml.html", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("<html>\n" +
                "<head>\n" +
                "<body>\n" +
                "<h1>I know basic concept of C#</h1>\n" +
                "<h2>I want to lear React.js in future</h2>\n" +
                "</body>\n" +
                "</head>\n" +
                "</html>");
            writer.Close();
            stream.Close();

        }

        private static void CaseStudyOneWritingInXml()
        {
            FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 10\\writeXml.xml",FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(stream);
           writer.WriteLine("<note>\n" +
                "<to>Tove</to>\n" +
                "<from>Jani</from>\n" +
                "<heading>Reminder</heading>\n" +
                "<body>Hello world india is leading in IT sector</body>\n" +
                "</note>");
            writer.Close();
            stream.Close();
        }
    }
}
