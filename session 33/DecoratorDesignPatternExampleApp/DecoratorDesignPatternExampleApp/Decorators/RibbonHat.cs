using DecoratorDesignPatternExampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExampleApp.Decorators
{
    internal class RibbonHat : IHat
    {
        
        

        public RibbonHat(IHat hat) 
        {
            Hat = hat;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
       

        public IHat Hat { get; set; }

        public void DescriptionOfProduct()
        {
            Console.WriteLine("The desscription of product is " + Hat.Description + "\n" + Description);
        }


        public void NameOfProduct()
        {
            Console.WriteLine("The Name of product is " + Hat.Name + " " + Name);
        }



        public void PriceOfProduct()
        {
            Console.WriteLine("The Price of product is " + (Hat.Price + Price));
        }
    }
}
