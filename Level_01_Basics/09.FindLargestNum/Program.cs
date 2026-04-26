using System;

    class LargestNumber
{
    static void Main()
    {
        int num1, num2, num3;

        Console.Write("Enter First Number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Third Number:");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("Largest Number is:" + num1);
        }
        else if (num2 >= num1 && num2>= num3)
        {
            Console.WriteLine("Largest number is:" +num2);
        }
        else
        {
            Console.WriteLine("Largest Number is:" +num3);
        }
    }
}
    
