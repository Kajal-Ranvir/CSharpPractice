using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string filePath = "data.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- File CRUD System ---");
            Console.WriteLine("1. Add Data");
            Console.WriteLine("2. View Data");
            Console.WriteLine("3. Delete Data");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddData();
                    break;
                case 2:
                    ViewData();
                    break;
                case 3:
                    DeleteData();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddData()
    {
        Console.Write("Enter data: ");
        string input = Console.ReadLine();

        File.AppendAllText(filePath, input + Environment.NewLine);

        Console.WriteLine("Data Saved!");
    }

    static void ViewData()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("\n--- Stored Data ---");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No data found!");
        }
    }

    static void DeleteData()
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine("All data deleted!");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}