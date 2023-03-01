using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart : " + product.Name);
        }

        public void Add2(string productName, string description, double price, int stockAmount)
        {
            Console.WriteLine("Added to cart : " + productName);
        }
    }
}
