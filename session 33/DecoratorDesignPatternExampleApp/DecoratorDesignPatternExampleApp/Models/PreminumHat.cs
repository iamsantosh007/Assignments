using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExampleApp.Models
{
    internal class PreminumHat:IHat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public void DescriptionOfProduct()
        {
            Console.WriteLine("The desscription of product is " + Description);
        }


        public void NameOfProduct()
        {
            Console.WriteLine("The Name of product is " + Name);
        }



        public void PriceOfProduct()
        {
            Console.WriteLine("The Price of product is " + Price);
        }
    }
}
