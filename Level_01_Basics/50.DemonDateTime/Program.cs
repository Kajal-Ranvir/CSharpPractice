using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date and Time: " + now);
        Console.WriteLine("Today's Date: " + now.ToShortDateString());
        Console.WriteLine("Current Time: " + now.ToShortTimeString());

        Console.ReadLine();
    }
}