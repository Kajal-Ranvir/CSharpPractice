using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}

class Program
{
    static List<User> users = new List<User>()
    {
        new User { Username = "admin", Password = "123", Role = "Admin" },
        new User { Username = "user", Password = "123", Role = "User" }
    };

    static void Main()
    {
        Console.WriteLine("--- Login System ---");

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        var user = users.Find(u => u.Username == username && u.Password == password);

        if (user != null)
        {
            Console.WriteLine($"Login Successful! Role: {user.Role}");

            if (user.Role == "Admin")
            {
                AdminMenu();
            }
            else
            {
                UserMenu();
            }
        }
        else
        {
            Console.WriteLine("Invalid credentials!");
        }
    }

    static void AdminMenu()
    {
        Console.WriteLine("\n--- Admin Panel ---");
        Console.WriteLine("You have full access!");
    }

    static void UserMenu()
    {
        Console.WriteLine("\n--- User Panel ---");
        Console.WriteLine("You have limited access!");
    }
}