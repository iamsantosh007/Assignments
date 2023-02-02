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
            StructExample cloneExpl = structExpl;

            cloneExpl.Name = "Patro";
            cloneExpl.ID = 44;

            Console.WriteLine(structExpl.Name + " " + structExpl.ID);
            Console.WriteLine(cloneExpl.Name+" "+cloneExpl.ID);
        }

        private static void CaseStudyForReferenceTypeClass()
        {
            ClassExample classExpl = new ClassExample("santosh", 33);
            ClassExample clonableClass = classExpl;

            clonableClass.Name = "Patro";
            clonableClass.ID = 44;

            Console.WriteLine(classExpl.Name + " " + classExpl.ID);
        }
    }
}
