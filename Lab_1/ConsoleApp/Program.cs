﻿using System;
using ClassLibrary;

class Program
{
    static void Main()
    {
        Warehouse warehouse = new();
        Money money = new(10, 50, "USD");
        Money money1 = new(20, 75, "USD");
        Money money2 = new(5, 30, "USD");

        Category electronics = new("Electronics", "Electronic devices");
        Category accessories = new("Accessories", "Gadgets and accessories");

        Product product = new("Laptop", money, electronics);
        Product product1 = new("Phone", money1, electronics);
        Product product2 = new("Headphones", money2, accessories);

        Reporting.RegisterIncome(warehouse, product, 5);
        Reporting.RegisterIncome(warehouse, product1, 10);
        Reporting.RegisterIncome(warehouse, product2, 15);

        warehouse.InventoryReport();
        warehouse.RemoveProduct(product, 2);
        warehouse.InventoryReport();

        product1.ReducePrice(new Money(2, 50, "USD"));
        Console.WriteLine($"New price for {product1.Name}: {product1.Price}");

        warehouse.RemoveProduct(product1, 5);
        warehouse.RemoveProduct(product2, 15);
        warehouse.InventoryReport();
    }
}
