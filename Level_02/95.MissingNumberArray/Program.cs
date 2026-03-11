using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,4,5};
        int n = 5;

        int expected = n*(n+1)/2;
        int sum = 0;

        foreach(int num in arr)
            sum += num;

        Console.WriteLine("Missing number: " + (expected - sum));
    }
}