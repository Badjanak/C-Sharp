/*
Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Don’t use arrays and the built-in sorting functionality.
 */

using System;

class Sort3Numbers
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        double third = double.Parse(Console.ReadLine());

        if (third > second)
        {
            double swap = second;
            second = third;
            third = swap;
        }
        if (third > first)
        {
            double swap = first;
            first = third;
            third = swap;
        }
        if (second > first)
        {
            double swap = first;
            first = second;
            second = swap;
        }

        Console.WriteLine("{0} {1} {2}", first, second, third);
    }
}