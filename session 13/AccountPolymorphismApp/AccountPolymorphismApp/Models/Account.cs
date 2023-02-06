using System;

namespace AccountPolymorphismApp.Models
{
    abstract class Account
    {
        protected int _accountNo;
        protected string _name;
        protected double _balance;
        protected string _accountType;


        public Account(int accountNo, string name, double balance, string accountType)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
            _accountType = accountType;
        }

        public void Deposite(double amount)
        {
            _balance+= amount;
        }

        public int AccountNo { get { return _accountNo; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }
        public string AccountType { get { return _accountType; } }
        public void GetAccountDetails()
        {
            Console.WriteLine($"Account number is {AccountNo}\n" +
                $"Name of persong is {Name}\n" +
                $"balance is {Balance}\n");


        }

        public abstract void WithdrawAmount(double withdrawAmount);
    }
}
