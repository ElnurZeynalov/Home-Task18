using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Order
    {
        private static int _no;
        public int No { get; }
        private int _productCount;
        public int ProductCount 
        { 
            get 
            {
                return _productCount; 
            }
            set
            {
                if(value>0)
                _productCount = value;
            }

        }
        public double TotalAmount { get; set; }
        //private DateTime _createdAt;
        public DateTime CreatedAt { get; set; } //set silmisdim zaman ferqin aydin olamsi ucun bele edledim
        public Order()
        {
            _no++;
            No = _no;
            //_createdAt = DateTime.Now;
            //CreatedAt = _createdAt;
        }
        public string ShowInfo()
        {
            return $"No: {No} - ProductCount: {ProductCount} - TotalAmount {TotalAmount} - CreatedAt: {CreatedAt}";
        }
    }
}
