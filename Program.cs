using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyApp2
{
    class Order
    {
        private int _id;
        private string _name;
        private int _totalprice = 0;
        private int _price;
        public List<string> list_of_orders = new List<string>();

        public Order(int id, string name, int price)
        {
            _id = id;
            _name = name;
            _totalprice += price;
            _price = price;
            list_of_orders.Add(name);
        }

        public void GetList()
        {
            foreach (var i in list_of_orders)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1253, "dfgdh", 55);
            Order order2 = new Order(1536, "dfggd", 86);
            order1.GetList();
        }
    }
}