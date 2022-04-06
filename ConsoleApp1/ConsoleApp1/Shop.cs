using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Shop
    {
        private List<Order> _orders;
        public Shop()
        {
            _orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double total = 0 ;
            foreach (var item in _orders)
            {
                total += item.TotalAmount;
            }
            return total/_orders.Count;
        }
        public double GetOrdersAvg(DateTime date)
        {
            var filtred = _orders.FindAll(x => x.CreatedAt > date);
            double total = 0 ;
            foreach (var item in filtred)
            {
                total += item.TotalAmount;
            }
            return total/filtred.Count;
        }
        public void RemoveOrderByNo(int? no)
        {
            if (no == null)
                throw new NullReferenceException();
            var removed = _orders.Find(x => x.No == no);
            if (removed == null)
                throw new NullReferenceException();
            _orders.Remove(removed);
        }
        public List<Order> FilterOrderByPrice(double minPrice, double maxPrice)
        {
            return _orders.FindAll(item => item.TotalAmount >= minPrice && item.TotalAmount <= maxPrice);
        }
        public List<Order> GetAllOrders()
        {
            List<Order> ordersCopy = new List<Order>();
            ordersCopy.AddRange(_orders);
            return ordersCopy;
        }
    }
}