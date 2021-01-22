﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 5;

            Product product2 = new Product
            { Id = 2, ProductName = "sandalye", UnitPrice = 250, UnitsInStock = 10 };

            //PascalCase kelimelerin ilk harfi büyük
            //camelcase harflerin hepsi küçük

            ProductManager productManager = new ProductManager();
            int sayi = 100;
            productManager.Add(sayi);
            Console.WriteLine(sayi);
        }
    }
}
