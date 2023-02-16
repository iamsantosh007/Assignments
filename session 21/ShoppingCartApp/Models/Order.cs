using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{
    public class Order
    {
        public Order() {
            Items = new List<LineItem>();

        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> Items { get; set; }

        public void Add(LineItem item)
        {
            Items.Add(item);
        }

        public double GetCheckOutPrice()
        {
            double totalLineItemCost = 0;
            foreach (LineItem item in Items)
            {
                totalLineItemCost += item.GetItemCost();
            }
            return totalLineItemCost;
        }
    }
}
