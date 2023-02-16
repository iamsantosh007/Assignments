using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{
    public class LineItem
    {
        public LineItem()
        {
            Product= new Product();
        }
        public int Id { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double GetItemCost()
        {
            return Product.GetPriceAfterDiscount()*Quantity;
        }
    }
}
