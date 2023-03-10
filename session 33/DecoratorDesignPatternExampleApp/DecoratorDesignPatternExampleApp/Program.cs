using DecoratorDesignPatternExampleApp.Decorators;
using DecoratorDesignPatternExampleApp.Models;

namespace DecoratorDesignPatternExampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudyPremiumAndRibbonHat();
            Console.WriteLine("\n\n");
            CaseStudyGoldenandStandardHat();
        }

        private static void CaseStudyGoldenandStandardHat()
        {
            IHat hat = new GoldenHat(new StandardHat() { Name = "Standard Hat", Description = "Standard hat with Leather", Price = 700 }) { Name = "Goldern Hat", Description = "Golden hat wiht Gold colour", Price = 1200 };
            hat.NameOfProduct();
            Console.WriteLine();
            hat.DescriptionOfProduct();
            Console.WriteLine();
            hat.PriceOfProduct();
        }

        private static void CaseStudyPremiumAndRibbonHat()
        {
            IHat hat = new RibbonHat(new PreminumHat() { Name = "premium Hat", Description = "Premium hat with diamond", Price = 700 }) { Name = "Ribbon Hat", Description = "Ribbon hat wiht blue ribbon", Price = 400 };
            hat.NameOfProduct();
            Console.WriteLine();
            hat.DescriptionOfProduct();
            Console.WriteLine();
            hat.PriceOfProduct();
        }
    }
}