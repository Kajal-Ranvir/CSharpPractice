using System;

class UserDetails
{
    static void Main()
    {
        // Declare variables
        string name;
        int age;
        string city;

        // Take input from user
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your city: ");
        city = Console.ReadLine();

        // Display user details
        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }
}