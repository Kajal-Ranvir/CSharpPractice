using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 2, 3, 4, 4, 5};

        HashSet<int> unique = new HashSet<int>(arr);

        Console.WriteLine("Array without duplicates:");

        foreach(int num in unique)
        {
            Console.Write(num + " ");
        }
    }
}