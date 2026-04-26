using System;

class Program
{
    static void ChangeValue(int x)
    {
        x = 100;
    }

    static void ChangeReference(int[] arr)
    {
        arr[0] = 100;
    }

    static void Main()
    {
        int a = 10;
        ChangeValue(a);
        Console.WriteLine("Value type: " + a);

        int[] nums = {10};
        ChangeReference(nums);
        Console.WriteLine("Reference type: " + nums[0]);
    }
}