/*
 Write a program that finds the biggest of three numbers that are read from the console.
 */

using System;

class BiggestOf3
{
    static void Main()
    {
        double biggest = double.MinValue;

        for (int i = 0; i < 3; i++)
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