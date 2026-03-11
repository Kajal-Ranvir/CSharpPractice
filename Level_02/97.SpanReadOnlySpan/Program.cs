using System;

class Program
{
    static void Main()
    {
        int[] numbers = {1,2,3,4,5};

        Span<int> span = numbers;
        span[0] = 10;

        ReadOnlySpan<int> readSpan = numbers;

        Console.WriteLine(numbers[0]);
    }
}