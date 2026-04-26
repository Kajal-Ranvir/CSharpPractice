using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        foreach(int n in arr)
            Console.Write(n + " ");
    }

    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        PrintArray(arr);
    }
}