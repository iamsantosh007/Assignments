using LSPSolutionBirdExample.Models;

namespace LSPSolutionBirdExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFly parrot = new Parrot("Fluppy", "Abc");
            IFly sparrow = new Sparrow("Tiger", "Mno");
            //IFly ostrich = new Ostrich("Blackie", "Black");
            Bird ostrich = new Ostrich("Blackie", "Black");
            AllBirdShouldFlyExceptOstrich(parrot);
            AllBirdShouldFlyExceptOstrich(sparrow);
            //AllBirdShouldFlyExceptOstrich(ostrich);
        }

        private static void AllBirdShouldFlyExceptOstrich(IFly flyingBird)
        {
            Console.WriteLine(flyingBird.Fly());
        }
    }
}