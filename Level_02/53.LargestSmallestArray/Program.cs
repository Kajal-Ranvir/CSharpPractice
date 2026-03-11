using System;

class Program
{
    static void Main()
    {
        int[] arr = {5, 2, 9, 1, 7};

        int largest = arr[0];
        int smallest = arr[0];

        foreach(int num in arr)
        {
            if(num > largest)
                largest = num;

            if(num < smallest)
                smallest = num;
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Smallest = " + smallest);
    }
}