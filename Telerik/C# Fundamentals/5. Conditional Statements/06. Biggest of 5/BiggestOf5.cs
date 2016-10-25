/*
 Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.
 */

using System;

class BiggestOf5
{
    static void Main()
    {
        double biggest = double.MinValue;

        for (int i = 0; i < 5; i++)
        {
            double current = double.Parse(Console.ReadLine());
            if (current > biggest)
            {
                biggest = current;
            }
        }

        Console.WriteLine("{0}", biggest);
    }
}