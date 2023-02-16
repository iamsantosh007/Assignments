using ShoppingCartApp.Models;

namespace ShoppingCartApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CaseStudyForProduct();
            //CaseStudyForLineItem();
            //CaseStudyForOrder();


            //1st custumer
            //CustomerOneDetails();
            //Console.WriteLine("\n\n\n\n");
            //2nd custumer
            //CustomerTwoDetails();
        }

        private static void CaseStudyForOrder()
        {
            Product productOne = new Product() { ID = 102, Name = "Chaska Maska", Price = 40, Discount = .10f };
            LineItem lineItemOne = new LineItem() { Id = 02, Product = productOne, Quantity = 45 };
             Order orderOne = new Order() { Id = 2, Date = new DateTime(2023, 04, 02, 2, 27, 44) };
            orderOne.Add(lineItemOne);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------Order Detail started-----------------------------\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"The Order id is {orderOne.Id}\n" +
                $"The order Date is {orderOne.Date.Day + "/" + orderOne.Date.Month + "/" + orderOne.Date.Year} and the Time in which order is placed {orderOne.Date.Hour + ":" + orderOne.Date.Minute + ":" + orderOne.Date.Second}");
                ItemsOfOrder(orderOne.Items);
        }

        private static void CaseStudyForLineItem()
        {
            Product productOne = new Product() { ID = 102, Name = "Chaska Maska", Price = 40, Discount = .10f };
            LineItem lineItemOne = new LineItem() { Id = 02, Product = productOne, Quantity = 45 };
            Console.WriteLine("lineItem item:-"+lineItemOne.Id+"\nLineItem qty:- "+lineItemOne.Quantity+"\nLineItem total value:-"+lineItemOne.GetItemCost()+"\nProduct details Are:-\n"+lineItemOne.Product.Name+" "+lineItemOne.Product.ID+" "+lineItemOne.Product.Price);
        }

        private static void CaseStudyForProduct()
        {
            Product productOne = new Product() { ID = 102, Name = "Chaska Maska", Price = 40, Discount = .10f };
            Console.WriteLine(productOne.ID+" "+productOne.Name+" "+productOne.Price);
        }

        private static void CustomerTwoDetails()
        {
            Product productOne = new Product() { ID = 102, Name = "Chaska Maska", Price = 40, Discount = .10f };
            LineItem lineItemOne = new LineItem() { Id = 02, Product = productOne, Quantity = 45 };


            Product productTwo = new Product() { ID = 103, Name = "Perk", Price = 10, Discount = .20f };
            LineItem lineItemTwo = new LineItem() { Id = 03, Product = productTwo, Quantity = 12 };


            Order orderOne = new Order() { Id = 2, Date = new DateTime(2023, 04, 02, 2, 27, 44) };
            orderOne.Add(lineItemOne);
            orderOne.Add(lineItemTwo);

            //End of order One


            //2nd order
            Product productThree = new Product() { ID = 104, Name = "Pulses", Price = 70, Discount = .50f };
            LineItem lineItemThree = new LineItem() { Id = 04, Product = productThree, Quantity = 55 };


            Product productFour = new Product() { ID = 105, Name = "Coco cola", Price = 90, Discount = .20f };
            LineItem lineItemFour = new LineItem() { Id = 05, Product = productFour, Quantity = 12 };


            Order orderTwo = new Order() { Id = 3, Date = new DateTime(2023, 05, 02, 1, 12, 25) };
            orderTwo.Add(lineItemThree);
            orderTwo.Add(lineItemFour);
            //end of order two

            //customerTwo start
            Custumer custumerTwo = new Custumer() { Id = 2, Name = "Ravi" };
            custumerTwo.Add(orderOne);
            custumerTwo.Add(orderTwo);
            PrintDetails(custumerTwo);
        }

        private static void CustomerOneDetails()
        {
            Product productOne = new Product() { ID = 101, Name = "Parle", Price = 500, Discount = .10f };
            LineItem lineItemOne = new LineItem() { Id = 01, Product = productOne, Quantity = 55 };


            Product productTwo = new Product() { ID = 102, Name = "DairyMilk", Price = 1000, Discount = .20f };
            LineItem lineItemTwo = new LineItem() { Id = 02, Product = productTwo, Quantity = 12 };


            Order orderOne = new Order() { Id = 1, Date = new DateTime(2023, 02, 01, 2, 25, 44) };
            orderOne.Add(lineItemOne);
            orderOne.Add(lineItemTwo);

            //End of order One





            //2nd order
            Product productThree = new Product() { ID = 103, Name = "Pepsi", Price = 200, Discount = .50f };
            LineItem lineItemThree = new LineItem() { Id = 03, Product = productThree, Quantity = 55 };


            Product productFour = new Product() { ID = 104, Name = "Rice", Price = 5300, Discount = .20f };
            LineItem lineItemFour = new LineItem() { Id = 04, Product = productFour, Quantity = 12 };


            Order orderTwo = new Order() { Id = 2, Date = new DateTime(2023, 02, 02, 1, 12, 25) };
            orderTwo.Add(lineItemThree);
            orderTwo.Add(lineItemFour);




            Custumer custumerOne = new Custumer() { Id = 1, Name = "santosh" };
            custumerOne.Add(orderOne);
            custumerOne.Add(orderTwo);
            PrintDetails(custumerOne);
        }

        private static void PrintDetails(Custumer custumer)
        {
            Console.WriteLine($"\t\t\tThe Id of Custumer is {custumer.Id}\n" +
                $"\t\t\t\tThe Name of Custumer is {custumer.Name}");
            foreach (var order in custumer.Order)
            {
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("--------------Order Detail started-----------------------------\n");
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine($"The Order id is {order.Id}\n" +
                    $"The order Date is {order.Date.Day + "/" + order.Date.Month + "/" + order.Date.Year} and the Time in which order is placed {order.Date.Hour + ":" + order.Date.Minute + ":" + order.Date.Second}");
               
                ItemsOfOrder(order.Items);
            }
        }

        private static void ItemsOfOrder(List<LineItem> items)
        {
            foreach(var item in items)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"---------------LineItem Detail is started--------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"LineItem id is :- {item.Id}\n" +
                    $"LineItem Quantity:- {item.Quantity}\n" +
                    $"LineItem Cost:- {item.GetItemCost()}");
                Console.ResetColor();

                Console.WriteLine($"--------------product Details Below:-------------------------\n" +
                        $"Product id is:-{item.Product.ID}\n" +
                    $"Product name is:-{item.Product.Name}\n" +
                    $"Product Price is:-{item.Product.Price}\n" +
                    $"Product discount is:-{item.Product.Discount}\n" +
                    $"Discounted Product per price:-{item.Product.GetPriceAfterDiscount()} \n" +
                    $"--------------product Details End----------------------------\n");
                
                Console.WriteLine();
            }
        }
    }
}