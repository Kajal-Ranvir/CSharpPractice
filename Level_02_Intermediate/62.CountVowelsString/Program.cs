using System;

class Program
{
    static void Main()
    {
        string str = "Hello World";
        int count = 0;

        foreach(char c in str.ToLower())
        {
            if("aeiou".Contains(c))
                count++;
        }

        Console.WriteLine("Vowels count: " + count);
    }
}