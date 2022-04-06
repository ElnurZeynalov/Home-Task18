using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.Totalamount = 51;
            order1.CreatedAt = DateTime.Now.AddMonths(-1);
            Order order2 = new Order();
            order2.Totalamount = 65;
            order2.CreatedAt = DateTime.Now.AddDays(-1);
            Order order3 = new Order();
            order3.Totalamount = 47;
            order3.CreatedAt = DateTime.Now;
            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);
            Console.WriteLine("=============GetOrdersAvg=================");
            Console.WriteLine(shop.GetOrdersAvg());
            Console.WriteLine("=============GetOrdersAvg(DateTime)=================");
            Console.WriteLine(shop.GetOrdersAvg(DateTime.Now.AddDays(-2)));
            Console.WriteLine("===============FilterOrderByPrice===============");
            foreach (var item in shop.FilterOrderByPrice(50,66))
            {
                Console.WriteLine(item.Totalamount);
            }
            Console.WriteLine("===========RemoveOrderByNo===========");
            shop.RemoveOrderByNo(2);
            foreach (var item in shop.GetAllOrders())
            {
                Console.WriteLine(item.ShowInfo());
            }
        }
    }
}
