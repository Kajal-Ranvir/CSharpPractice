using System;

class ConditionalDemo
{
    static void Main()
    {
        int number = 10;

        // 1. if statement
        if (number > 0)
        {
            Console.WriteLine("Number is positive");
        }

        // 2. if-else statement
        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }

        // 3. else-if ladder
        int marks = 75;

        if (marks >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }

        // 4. switch statement
        int day = 3;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }
    }
}