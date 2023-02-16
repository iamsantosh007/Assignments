using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public float Discount { get; set; }

        public double Price { get; set; }

        public double GetPriceAfterDiscount()
        {
            return Price-(Price*Discount);
        }
    }
}
