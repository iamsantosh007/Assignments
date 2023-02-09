using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface.Models
{
    public class Bike:IMovable
    {
        private string _brand;
        private string _model;
        public Bike(string brand,string model)
        {
            _brand= brand;
            _model= model;
        }
        public string Brand { get { return _brand; } }
        public string Model { get { return _model;} }

        public void Move()
        {
            Console.WriteLine($"The Bike is Moving of {Brand} brand and having model {Model}");
        }
    }
}
