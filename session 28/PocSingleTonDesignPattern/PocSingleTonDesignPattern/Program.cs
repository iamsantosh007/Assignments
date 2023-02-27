using PocSingleTonDesignPattern.Models;

namespace PocSingleTonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account=Account.GetInstance(1,"santosh");
            //Console.WriteLine(account.Name.GetHashCode());
            account.ShowDetails();
            Account acc2 = Account.GetInstance(1,"Patro");
            //Console.WriteLine(account.Name.GetHashCode());
            account.ShowDetails();

            Console.WriteLine(account.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());
        }
    }
}