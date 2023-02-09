using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface.Models
{
    public class Truck:IMovable
    {
        private string _brand;
        private string _model;
        public Truck(string brand,string model)
        {
           _model = model;
            _brand = brand;
        }
        public string Brand { get { return _brand; } }
        public string Model { get { return _model; } }
        public void Move()
        {
            Console.WriteLine($"The Truck is Moving of {Brand} brand and having model {Model}");
        }
    }
}
