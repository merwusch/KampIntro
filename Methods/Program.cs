// See https://aka.ms/new-console-template for more information
using Methods;

Console.WriteLine("Hello, World!");

//Dont repeat yourself - DRY - Clean Code - Best Practice

Product product1 = new Product();

product1.Id = 1;
product1.Name = "Table";
product1.Description = "Working Table";
product1.Price = 500;
product1.StockAmount = 3;

Product product2 = new Product();

product2.Id = 2;
product2.Name = "Chair";
product2.Description = "Working Chair";
product2.Price = 100;
product2.StockAmount = 5;

Product[] products = new Product[] { product1, product2 };

//type safe (var)
foreach (var product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Description);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.StockAmount);
    Console.WriteLine("---------------");
}

Console.WriteLine("---------------Methods---------------");

//instance - class örneği oluşturma
//encapsulation

CartManager cartManager = new CartManager();
cartManager.Add(product1);
cartManager.Add(product2);

cartManager.Add2("Pear", "Green pear", 5, 300);
cartManager.Add2("Apple", "Red apple", 10, 500);
cartManager.Add2("Orange", "Juicy orange", 15, 1000);

