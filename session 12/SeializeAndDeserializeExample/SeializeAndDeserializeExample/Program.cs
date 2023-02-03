
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SeializeAndDeserializeExample.Dtos;
using SeializeAndDeserializeExample.Models;

namespace SeializeAndDeserializeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CaseStudyOneSerialize();
            CaseStudyTwoDeserialize();
        }

        
        private static void CaseStudyTwoDeserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AccountDTO));
            using (StreamReader reader = new StreamReader("E:\\Swabhav Assignments\\session 12\\Account.xml"))
            {
                AccountDTO account = (AccountDTO)xmlSerializer.Deserialize(reader);
                Console.WriteLine($"Balance {account.Balance} and name is {account.Name}");
            }

        }

        private static void CaseStudyOneSerialize()
        {
            
            Account account = new Account(101,"santosh",5000);
            account.DepositeAmount(5000);
            
            //Console.WriteLine(account.GetBalance());
            AccountDTO dto= account.GenerateDTO();
            XmlSerializer serializer = new XmlSerializer(typeof(AccountDTO));
            using (StreamWriter writer = new StreamWriter("E:\\Swabhav Assignments\\session 12\\Account.xml"))
            {
                serializer.Serialize(writer, dto);
                
            }
        }
    }
}
