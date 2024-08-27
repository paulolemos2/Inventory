using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

public static class ProductOperations
{
    public static List<Product> OrderProducts(List<Product> Products, string sortKey, bool ascending)
    {
        switch (sortKey)
        {
            case "Name":
                return ascending
                    ? [.. Products.OrderBy(p => p.Name)]
                    : [.. Products.OrderByDescending(p => p.Name)];

            case "Price":
                return ascending
                    ? [.. Products.OrderBy(p => p.Price)]
                    : [.. Products.OrderByDescending(p => p.Price)];

            case "Stock":
                return ascending
                    ? [.. Products.OrderBy(p => p.Stock)]
                    : [.. Products.OrderByDescending(p => p.Stock)];

            default:
                throw new ArgumentException("Invalid sort key");
        }
    }
}