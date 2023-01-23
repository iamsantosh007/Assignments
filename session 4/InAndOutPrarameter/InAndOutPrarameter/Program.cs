using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace InAndOutPrarameter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;                             //use of out parameter
            GetName("santosh","patro",out fullName);
            Console.WriteLine(fullName);
            Console.WriteLine("----------------------");

            bool result=false;                            //use of out,in and int.TryParse()
            int countryCode = 91;
            int mobileNumber;
            string fullMobileNum;
            GetUserNumber(out mobileNumber, result);
            GetFullMobileNumber(countryCode,out fullMobileNum,mobileNumber);
            Console.WriteLine(fullMobileNum);
            Console.ReadLine();
        }
        public static void GetName(string firstName,string lastName,out string fullName)
        {
            fullName = firstName + " " + lastName;
        }

        public static void GetUserNumber(out int mobileNumber,bool result)
        {
            Console.Write("enter your number:- ");
            
            result = int.TryParse(Console.ReadLine(),out mobileNumber);
            
            
        }

        public static void GetFullMobileNumber(in int countryCode,out string fullNumber,in int mobileNum)
        {
            fullNumber=countryCode.ToString()+mobileNum.ToString();

        }

    }
}
