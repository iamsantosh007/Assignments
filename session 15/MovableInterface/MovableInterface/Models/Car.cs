using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface.Models
{
    public class Car:Movable
    {

        public Car(string brand,string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public override void Move() 
        {
            Console.WriteLine($"The Car is Moving of {this.brand} brand and having model {this.model}");
        }
    }
}
