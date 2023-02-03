using RefTypeClassAndValueTypeStrucExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeClassAndValueTypeStrucExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("example for reference Type:-");
            CaseStudyForReferenceTypeClass();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("example for Value Type:-");
            CaseStudyForValueTypeStruct();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

        }

        private static void CaseStudyForValueTypeStruct()
        {
            StructExample structExpl = new StructExample(33,"santosh");
            StructExample refStructExpl = structExpl;

            refStructExpl.Name = "Patro";
            refStructExpl.ID = 44;

            Console.WriteLine(structExpl.Name + " " + structExpl.ID);
            Console.WriteLine(refStructExpl.Name+" "+refStructExpl.ID);
        }

        private static void CaseStudyForReferenceTypeClass()
        {
            ClassExample classExpl = new ClassExample("santosh", 33);
            ClassExample refClassExample = classExpl;

            refClassExample.Name = "Patro";
            refClassExample.ID = 44;

            Console.WriteLine(classExpl.Name + " " + classExpl.ID);
        }
    }
}
