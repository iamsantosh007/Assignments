using AccountPolymorphismApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static List<Saving> savingAccountList = new List<Saving>();
        static List<CurruntAccount> currentAccountList = new List<CurruntAccount>();
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Bank of Santosh");
            Start();
            Console.ReadLine();


        }
        static bool start = true;
        
        public static void Start()
        {
            try
            {
                while (start)
                {
                    Console.WriteLine("Main bank Account Section");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1-saving account\n" +
                        "2-currunt account\n" +
                        "3-exit");
                    Console.WriteLine("------------------------");
                    Console.Write("enter your choice:- ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:

                            AccountSection(choice);
                            break;
                        case 2:

                            AccountSection(choice);
                            break;


                    }
                }
            }catch(Exception ex) {
                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("oops !! please Enter correct choice");
                Console.WriteLine();
                Console.WriteLine();
                Start();

            }
        }
        public static void AccountSection(int choice)
        {
            try
            {
                string name = "";
                if (choice == 1)
                {
                    name = "Saving Account";

                }
                if (choice == 2)
                {
                    name = "Currunt";

                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Welcome to {name} Section");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1-Add\n" +
                    "2-View Account\n" +
                    "3-Remove\n" +
                    "4-Transaction Section\n" +
                    "5-Main Account Section\n" +
                    "6-Exit");
                Console.Write("Enter your choice:- ");
                int choiceAccount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------");
                Console.WriteLine();

                switch (choiceAccount)
                {
                    case 1:

                        if (AddAccount(choice))
                        {
                            Console.WriteLine("successfully added");
                            Console.WriteLine("---------------------");
                            AccountSection(choice);
                            return;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Not added Account Maybe you didnot enter name or negative amount ");
                        Console.WriteLine();
                        Console.WriteLine();
                        AccountSection(choice);
                        break;
                    case 2:
                        ViewAccount(choice);
                        AccountSection(choice);
                        break;
                    case 3:
                        if (RemoveAccount(choice))
                        {
                            Console.WriteLine("SuccessFully removed your Account");
                            Console.WriteLine();
                            Console.WriteLine();
                            AccountSection(choice);
                            return;
                        }
                        Console.WriteLine("Unable to remove your account");
                        AccountSection(choice);
                        break;
                    case 4:
                        TransactionAmount(choice);
                        break;
                    case 5:
                        Start();
                        break;
                    case 6:
                        start = false;
                        break;
                    default:
                        Console.WriteLine("enter valid number");
                        AccountSection(choice);
                        break;






                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("oops !! Fill all fields");
                Console.WriteLine();
                Console.WriteLine();
                AccountSection(choice);
            }
        }

        public static bool AddAccount(int choice)
        {
            try {
                Random r = new Random();
                int AccountNo = r.Next(1000, 5000);
                Console.Write("enter your name:-");
                String name = Console.ReadLine();
                Console.Write("enter initial balance:- ");
                string num= Console.ReadLine();
                if(!(string.IsNullOrEmpty(num))&&Convert.ToInt32(num)<0)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("cant take negative number");
                    Console.WriteLine("-------------------------");
                    return false;
                }
                if (string.IsNullOrEmpty(num) && choice==1 && !(string.IsNullOrEmpty(name)))
                {
                    Saving savingAccount = new Saving(AccountNo, name);
                    savingAccountList.Add(savingAccount);
                    PrintTempDetail(savingAccount);
                    return true;
                }
                if (!(string.IsNullOrEmpty(num)) && choice == 1 && !(string.IsNullOrEmpty(name))) {
                    double balance = Convert.ToDouble(num);
                    Saving savingAccount = new Saving(AccountNo, name,balance);
                    savingAccountList.Add(savingAccount);
                    PrintTempDetail(savingAccount);
                    return true;

                }
                if(string.IsNullOrEmpty(num) && choice == 2 && !(string.IsNullOrEmpty(name)))
                {
                    CurruntAccount curruntAccount = new CurruntAccount(AccountNo, name);
                    currentAccountList.Add(curruntAccount);
                    PrintTempDetail(curruntAccount);
                    return true;

                }
                if(!(string.IsNullOrEmpty(num)) && choice == 2 && !(string.IsNullOrEmpty(name)) )
                {
                    double balance = Convert.ToDouble(num);
                    CurruntAccount curruntAccount = new CurruntAccount(AccountNo, name, balance);
                    currentAccountList.Add(curruntAccount);
                    PrintTempDetail(curruntAccount);
                    return true;
                }
                
                

            }catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("Oops !! Fill all fields");
                Console.WriteLine();
                Console.WriteLine();
                AccountSection(choice);
            }
            return false;


        }

        //printing account details in AddAccount() when user enter all his information.
        public static void PrintTempDetail(Account acc)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Account number is :- {acc.AccountNo}\n" +
                $"Name is {acc.Name}\n" +
                $"Balance is {acc.Balance}");
            Console.WriteLine("--------------------------------------");
        }

        public static void ViewAccount(int choice)
        {
            try
            {
                Console.Write("enter your account number to search:- ");
                int a = Convert.ToInt32(Console.ReadLine());
                int check = FindAccount(choice, a);
                if (check >= 0 && choice == 1)
                {
                    Account accountInfo = savingAccountList.ElementAt(check);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Account type is:- " + accountInfo.AccountType);
                    Console.WriteLine($"Account number is:- {accountInfo.AccountNo}\n" +
                        $"Name is {accountInfo.Name}\n" +
                        $"Balance is {accountInfo.Balance}");
                    Console.WriteLine("------------------------------------------");
                    return;
                }
                if (check >= 0 && choice == 2)
                {
                    Account accountInfo = currentAccountList.ElementAt(check);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Account type is:- " + accountInfo.AccountType);
                    Console.WriteLine($"Account number is:- {accountInfo.AccountNo}\n" +
                        $"Name is {accountInfo.Name}\n" +
                        $"Balance is {accountInfo.Balance}");
                    Console.WriteLine("------------------------------------------");
                    return;
                }

                Console.WriteLine("Look like you dont have any account");
                Console.WriteLine();
                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("Oops !! Fill all fields");
                Console.WriteLine();
                Console.WriteLine();
                ViewAccount(choice);    
            }
        }

        //public static int FindAccount(int SearchAccountNo)
        //{
        //    int count = 0;

        //    foreach (var accountInfo in savingAccountList)
        //    {
        //        if (accountInfo.AccountNo == SearchAccountNo)
        //        {
        //            return count;
        //        }

        //    }

        //    foreach (var accountInfo in currentAccountList)
        //    {
        //        if (accountInfo.AccountNo == SearchAccountNo)
        //        {
        //            return count;
        //        }

        //    }
        //    return -1;
        //}

        public static int FindAccount(int choice, int SearchAccountNo)
        {
            int count = 0;
            if (choice == 1)
            {
                foreach (var accountInfo in savingAccountList)
                {
                    if (accountInfo.AccountNo == SearchAccountNo)
                    {
                        return count;
                    }
                    count++;

                }
                return -1;

            }
            if (choice == 2)
            {
                foreach (var accountInfo in currentAccountList)
                {
                    if (accountInfo.AccountNo == SearchAccountNo)
                    {
                        return count;
                    }
                    count++;

                }
                return -1;
            }
            return -1;
        }

        public static bool RemoveAccount(int choice)
        {
            try {
                    Console.Write("enter the account number you want to delete:- ");
                    int AccountNo = Convert.ToInt32(Console.ReadLine());
                    int indexNumber = FindAccount(choice, AccountNo);
                    if (choice == 1)
                    {
                        savingAccountList.RemoveAt(indexNumber);
                        return true;
                    }
                    if (choice == 2)
                    {
                        currentAccountList.RemoveAt(indexNumber);
                        return true;
                    }
                    

            }catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("Oops !! Fill all fields");
                Console.WriteLine();
                Console.WriteLine();
                RemoveAccount(choice);
            }
            return false;
            
        }

        //public static void Testing()
        //{
        //    Console.WriteLine("saving-----------------------------");
        //    foreach (var accountInfo in savingAccountList)
        //    {
        //        Console.WriteLine($"Account number is:- {accountInfo.AccountNo}\n" +
        //            $"Name is {accountInfo.Name}\n" +
        //            $"Balance is {accountInfo.Balance}");
        //    }
        //    Console.WriteLine("currunt----------------------------");
        //    foreach (var accountInfo in currentAccountList)
        //    {
        //        Console.WriteLine($"Account number is:- {accountInfo.AccountNo}\n" +
        //            $"Name is {accountInfo.Name}\n" +
        //            $"Balance is {accountInfo.Balance}");
        //    }
        //}

        public static void TransactionAmount(int choice)
        {
            try
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("1-Deposite\n" +
                "2-Withdraw\n" +
                "3-Bank menu\n" +
                "4-Main page\n" +
                "5-View balance\n" +
                "6-exite");
                Console.Write("enter your choice:- ");
                int transactionChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                switch (transactionChoice)
                {
                    case 1:
                        DepositeAmount(choice);
                        TransactionAmount(choice);
                        break;
                    case 2:
                        WithdrawAmount(choice);
                        TransactionAmount(choice);
                        break;
                    case 3:
                        AccountSection(choice);
                        break;
                    case 4:
                        Start();
                        break;
                    case 5:
                        ViewAccount(choice);
                        TransactionAmount(choice);
                        break;
                    case 6:
                        start = false;
                        break;




                }
            }catch(Exception e)
            {

                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("Invalid");
                Console.WriteLine();
                Console.WriteLine();
                TransactionAmount(choice);
            }
            
        }

        public static void DepositeAmount(int choice)
        {
            try {

                Console.WriteLine("enter account number:- ");
                int accNumber = Convert.ToInt32(Console.ReadLine());


                int indexNum = FindAccount(choice, accNumber);
                if (indexNum < 0)
                {
                    Console.WriteLine("No Account found");
                    Console.WriteLine();
                    Console.WriteLine();
                    return;
                }
                Console.Write("enter the amount to deposite:- ");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("negative amount not allowed");
                }
                if (choice == 1)
                {
                    Account accinfo = savingAccountList.ElementAt(indexNum);
                    accinfo.Deposite(amount);
                    Console.WriteLine($"deposite successfull of amount {amount}");
                    Console.WriteLine();
                    Console.WriteLine();
                    return;
                }
                if (choice == 2)
                {
                    Account accinfo = currentAccountList.ElementAt(indexNum);
                    accinfo.Deposite(amount);
                    Console.WriteLine($"deposite successfull of amount {amount}");
                    Console.WriteLine();
                    Console.WriteLine();
                    return;
                }


            }
            catch (Exception e)
            {

                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("Field missmatch");
                Console.WriteLine();
                Console.WriteLine();
                DepositeAmount(choice);
            }

        }
        public static void WithdrawAmount(int choice)
        {
            try
            {
                Console.WriteLine("enter account number:- ");
                int accNumber = Convert.ToInt32(Console.ReadLine());
                int indexNum = FindAccount(choice, accNumber);
                if (indexNum < 0)
                {
                    Console.WriteLine("No Account found");
                    return;
                }
                Console.Write("enter the amount to Withdraw:- ");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (choice == 1)
                {
                    Account accinfo = savingAccountList.ElementAt(indexNum);
                    accinfo.WithdrawAmount(amount);
                    if (((Saving)accinfo).IsWithdraw)
                    {
                        Console.WriteLine($"withdraw successfull of Rs.{amount}");
                        return;
                    }
                    Console.WriteLine($"You already having {accinfo.Balance} and you have to maintain Rs.1000 in your account");
                    Console.WriteLine();
                    Console.WriteLine();
                    return;
                }
                if (choice == 2)
                {
                    int overDraftLimit = -5000;
                    Account accinfo = currentAccountList.ElementAt(indexNum);

                    if (accinfo.Balance == overDraftLimit)
                    {

                        Console.WriteLine($"withdraw unsuccessfull Becoz you used all your overDraft limit and your balance is {accinfo.Balance}");
                        Console.WriteLine();
                        Console.WriteLine();
                        return;
                    }
                    accinfo.WithdrawAmount(amount);
                    // Console.WriteLine($"Withdraw successfull of amount {amount} and your remaining withdrwa limit is {accinfo._overDraftLimit} and main balance is {accinfo.Balance}");
                    Console.WriteLine($"Withdraw successfull of amount {amount} and main balance is {accinfo.Balance}");
                    return;
                }
            }catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("-------------Exception Occur---------------");
                Console.WriteLine("Field missmatch");
                Console.WriteLine();
                Console.WriteLine();
                WithdrawAmount(choice);
            }
        }

        
    }
}
