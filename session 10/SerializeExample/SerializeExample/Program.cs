using SerializeExample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    public class Program
    {
        public static List<Student> students=new List<Student>();
        static void Main(string[] args)
        {

            
            CaseStudyOneWriting();
            Console.WriteLine("---------Writing Done-----------");
           
        }

       

        private static void CaseStudyOneWriting()
        { 

            Student student=new Student("Patro",15);
            StreamWriter writer;
            if(!File.Exists("E:\\Swabhav Assignments\\session 10\\UserData.txt"))
            {
                writer = new StreamWriter("E:\\Swabhav Assignments\\session 10\\UserData.txt");
                return;
            }
            writer = File.AppendText("E:\\Swabhav Assignments\\session 10\\UserData.txt");
            writer.WriteLine(student.Name+" "+student.Age);
            writer.Close();





        }
    }
}
