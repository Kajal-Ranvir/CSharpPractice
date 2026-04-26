using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double BasicSalary { get; set; }

    public double CalculateSalary()
    {
        double hra = BasicSalary * 0.20;
        double da = BasicSalary * 0.10;
        return BasicSalary + hra + da;
    }
}

class Program
{
    static List<Employee> employees = new List<Employee>();
    static int idCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Employee Payroll System ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Calculate Salary");
            Console.WriteLine("4. Exit");
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
                    ShowSalary();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddEmployee()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        employees.Add(new Employee
        {
            Id = idCounter++,
            Name = name,
            BasicSalary = salary
        });

        Console.WriteLine("Employee Added!");
    }

    static void ViewEmployees()
    {
        Console.WriteLine("\n--- Employee List ---");

        foreach (var e in employees)
        {
            Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Basic Salary: {e.BasicSalary}");
        }
    }

    static void ShowSalary()
    {
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var emp = employees.Find(e => e.Id == id);

        if (emp != null)
        {
            Console.WriteLine($"Total Salary: {emp.CalculateSalary()}");
        }
        else
        {
            Console.WriteLine("Employee not found!");
        }
    }
}