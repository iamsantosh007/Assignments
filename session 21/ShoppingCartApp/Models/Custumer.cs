using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{
    public class Custumer
    {


        public Custumer()
        {
            Order = new List<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Order { get; set; }

        public void Add(Order order)
        {
            Order.Add(order);
        }

        public double GetTotalCartValue()
        {
            double totalCartValue = 0;
            foreach(Order order in Order)
            {
               totalCartValue+=order.GetCheckOutPrice();
            }
            return totalCartValue;
        }
       

    }
}
