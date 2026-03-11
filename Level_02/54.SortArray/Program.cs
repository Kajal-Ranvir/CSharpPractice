using System;

class Program
{
    static void Main()
    {
        int[] arr = {5, 3, 8, 1, 2};

        Array.Sort(arr);

        Console.WriteLine("Sorted Array:");

        foreach(int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}