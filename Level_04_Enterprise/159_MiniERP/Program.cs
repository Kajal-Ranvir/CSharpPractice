using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static List<Employee> employees = new List<Employee>();
    static List<Product> products = new List<Product>();

    static int empId = 1;
    static int prodId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Mini ERP System ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Add Product");
            Console.WriteLine("4. View Products");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    ViewEmployees();
                    break;
                case 3:
                    AddProduct();
                    break;
                case 4:
                    ViewProducts();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddEmployee()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        employees.Add(new Employee
        {
            Id = empId++,
            Name = name
        });

        Console.WriteLine("Employee Added!");
    }

    static void ViewEmployees()
    {
        Console.WriteLine("\n--- Employees ---");

        foreach (var e in employees)
        {
            Console.WriteLine($"ID: {e.Id}, Name: {e.Name}");
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        products.Add(new Product
        {
            Id = prodId++,
            Name = name
        });

        Console.WriteLine("Product Added!");
    }

    static void ViewProducts()
    {
        Console.WriteLine("\n--- Products ---");

        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}");
        }
    }
}