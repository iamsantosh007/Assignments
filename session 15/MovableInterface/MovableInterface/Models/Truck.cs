using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface.Models
{
    public class Truck:Movable
    {
        public Truck(string brand,string model)
        {
            this.model = model;
            this.brand = brand;
        }

        public override void Move()
        {
            Console.WriteLine($"The Truck is Moving of {this.brand} brand and having model {this.model}");
        }
    }
}
