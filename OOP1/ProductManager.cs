﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            product.ProductName = "Camera";
            Console.WriteLine(product.ProductName + " added.");
        } 

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");
        }

        internal void BiseyYap(int sayi)
        {
            sayi = 99;
        }
    }
}
