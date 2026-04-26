using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 20, 30, 40, 50};

        Console.Write("Enter element to search: ");
        int key = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach(int num in arr)
        {
            if(num == key)
            {
                found = true;
                break;
            }
        }

        if(found)
            Console.WriteLine("Element Found");
        else
            Console.WriteLine("Element Not Found");
    }
}