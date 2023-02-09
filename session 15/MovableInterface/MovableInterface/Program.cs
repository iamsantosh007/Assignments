using MovableInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("TATA","Nano");
            var Bike = new Bike("Royal Enfield", "350 classic");
            var truck = new Truck("Eicher Moters", "Mini Truck 800");

            IMovable[] movables = new IMovable[] { car, Bike, truck };
            StartTheRace(movables);
        }

        public static void StartTheRace(IMovable[] movable)
        {
            foreach (var moving in movable) 
            {
                moving.Move();
                Console.WriteLine();
            }
        }
    }
}
