using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface.Models
{
    public class Car:IMovable
    {
        private string _brand;
        private string _model;
        public Car(string brand,string model)
        {
            _brand= brand;
            _model= model;
        }

        public string Brand { get { return _brand; } }
        public string Model { get { return _model; } }
        public void Move() 
        {
            Console.WriteLine($"The Car is Moving of {Brand} brand and having model {Model}");
        }
    }
}
