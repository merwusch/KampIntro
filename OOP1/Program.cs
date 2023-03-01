using OOP1;


    Product product1 = new Product();
    product1.Id = 1;
    product1.CategoryId = 2;
    product1.ProductName = "Desk";
    product1.UnitPrice = 500;
    product1.UnitsInStock = 3;

    Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Pencil", UnitPrice = 35 };

    //PascalCase   //camelCase
    ProductManager productManager = new ProductManager();
    productManager.Add(product1);
    Console.WriteLine(product1.ProductName);//kamera dondurur cunku referans degeri aktarilmis olur

int sayi = 100;
productManager.BiseyYap(sayi);
Console.WriteLine(sayi);//100 verir cunku fonk icinde sayi 99 olsa da disari verilmez
productManager.Update(product2);


//int, double, bool... deger tip
//diziler, class, abstract class, interface... referans tip
//ref out
