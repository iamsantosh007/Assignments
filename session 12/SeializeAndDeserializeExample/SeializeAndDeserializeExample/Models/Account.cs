using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SeializeAndDeserializeExample.Dtos;
using SeializeAndDeserializeExample.Models;

namespace SeializeAndDeserializeExample.Models
{
    
    public class Account
    {
       //[XmlElement(DataType ="int")]
        private int _accountNumber;
        //[XmlElement(DataType="Name")]
        private string _name;
        //[XmlElement(DataType ="double")]
        private double _balance;
        private const int MinimumBalance= 1000;
        private static int _count;
        private AccountDTO _accountDTO;
        static Account()
        {
            _count=0;
        }

        
        public Account()
        {
            
        }
        public Account(int accountNumber, string name, double balance)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance= balance;
            _count++;
            _accountDTO=new AccountDTO();
            
        }

        public Account(int accountNumber,string name):this(accountNumber,name,MinimumBalance)
        {
           
        }

        [XmlElement("AccountNumber")]
        public int AccountNumber { 
            get {
                return _accountNumber;
            }
            set { }
        }

        public int Count { get { return _count; } }

        [XmlElement("Name")]
        public string Name { get { return _name; }  }

        [XmlElement("Balance")]
        public double Balance { get { return _balance; }  }

        
        public void DepositeAmount(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public static int GetHeadCount()
        {
            return _count;
        }
        public void WithdrawAmount(double amount)
        {
            if(HasSufficientBalace(amount))
            {
                _balance-=amount;
                return;

            }
            throw new Exception("Cant withdraw because balace is already 0");
        }

        public double GetBalance()
        {
            return _balance;
        }
        private bool HasSufficientBalace(double amount)
        {
            return _balance-amount >=MinimumBalance;
        }

        public AccountDTO GenerateDTO()
        {
            
            _accountDTO.Balance = Balance;
            _accountDTO.Name = Name;
            _accountDTO.AccountNumber = AccountNumber;
            return _accountDTO;
        }

    }
}
