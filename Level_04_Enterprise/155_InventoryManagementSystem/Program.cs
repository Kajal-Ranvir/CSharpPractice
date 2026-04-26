using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }

    public void AddStock(int qty)
    {
        Quantity += qty;
    }

    public void ReduceStock(int qty)
    {
        if (qty <= Quantity)
            Quantity -= qty;
        else
            Console.WriteLine("Not enough stock!");
    }
}

class Program
{
    static List<Product> products = new List<Product>();
    static int idCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Inventory Management System ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Add Stock");
            Console.WriteLine("4. Reduce Stock");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;

                case 2:
                    ViewProducts();
                    break;

                case 3:
                    AddStock();
                    break;

                case 4:
                    ReduceStock();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Initial Quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        products.Add(new Product
        {
            Id = idCounter++,
            Name = name,
            Quantity = qty
        });

        Console.WriteLine("Product Added!");
    }

    static void ViewProducts()
    {
        Console.WriteLine("\n--- Product List ---");

        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}");
        }
    }

    static void AddStock()
    {
        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var product = products.Find(p => p.Id == id);

        if (product != null)
        {
            Console.Write("Enter Quantity to Add: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            product.AddStock(qty);
            Console.WriteLine("Stock Updated!");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    static void ReduceStock()
    {
        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var product = products.Find(p => p.Id == id);

        if (product != null)
        {
            Console.Write("Enter Quantity to Reduce: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            product.ReduceStock(qty);
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }
}