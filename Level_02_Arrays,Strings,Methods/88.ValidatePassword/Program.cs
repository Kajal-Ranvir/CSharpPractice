using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string password = "Abc@1234";

        bool strong = Regex.IsMatch(password,
            @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$");

        Console.WriteLine(strong ? "Strong Password" : "Weak Password");
    }
}