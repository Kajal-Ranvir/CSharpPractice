using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "Hello";

        if(str1.Equals(str2))
            Console.WriteLine("Strings are Equal");
        else
            Console.WriteLine("Strings are Not Equal");
    }
}