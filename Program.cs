using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var Products = new List<Product>
        {
            new() { Name = "Product A", Price = 100, Stock = 5 },
            new() { Name = "Product B", Price = 200, Stock = 3 },
            new() { Name = "Product C", Price = 50, Stock = 10 }
        };

        string sortKey = "Price";
        bool ascending = false;

        var OrderedProducts = ProductOperations.OrderProducts(Products, sortKey, ascending);

        foreach (var Product in OrderedProducts)
        {
            Console.WriteLine($"Name: {Product.Name}, Price: {Product.Price}, Stock: {Product.Stock}");
        }
    }
}