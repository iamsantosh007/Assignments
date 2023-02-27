using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSingleTonDesignPattern.Models
{
    public class Account
    {
        private int _id;
        private string _name;
        private static Account _accounts;

        private Account(int id,string name)
        {
            _id= id;
            _name= name;
        }
        public int Id { get { return _id; } set { _id = value; } }

        public string Name { get { return _name; } set { _name = value; } }
        public static Account GetInstance(int id,string name)
        {
            
            if (_accounts == null)
            { 
                return _accounts=new Account(id,name);
            }
            _accounts.Id = id;
            _accounts.Name = name;
            return _accounts;

        }

        public void ShowDetails()
        {
            Console.WriteLine($"The ID is {Id} and name is {Name}");
        }

    }
}
