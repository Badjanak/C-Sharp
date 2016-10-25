/*
 Write a program that reads two double values from the console A and B, 
 stores them in variables and exchanges their values if the first one is greater than the second one. 
 Use an if-statement. 
 As a result print the values of the variables A and B, separated by a space.
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());

        if (first > second)
        {
            double swap = first;
            first = second;
            second = swap;
        }

        Console.WriteLine("{0} {1}", first, second);
    }
}