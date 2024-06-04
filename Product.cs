using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group6_Assignment_2
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, double price, int stock)
        {

            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int value)
        {

            Stock += value;
        }

        public void DecreaseStock(int value)
        {

            if (Stock >= value)
            {
                Stock -= value;
            }
            else
            {
                Console.WriteLine("Insufficient stock to decrease.");
            }
        }
    }
}
