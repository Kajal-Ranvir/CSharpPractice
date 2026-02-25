using System;

class DisplayUserDetails
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}