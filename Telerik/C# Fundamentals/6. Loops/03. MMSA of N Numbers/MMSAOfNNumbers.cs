/*
 Write a program that reads from the console a sequence of N integer numbers 
 and returns the minimal, the maximal number, the sum and the average of all numbers 
 (displayed with 2 digits after the decimal point).
 */

using System;

class MMSAOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        double max = double.MinValue;
        double min = double.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            double input = double.Parse(Console.ReadLine());

            sum += input;

            if (input > max)
            {
                max = input;
            }

            if (input < min)
            {
                min = input;
            }
        }
        double average = sum / n;

        Console.WriteLine("min={0:f2}\nmax={1:f2}\nsum={2:f2}\navg={3:F2}"
            , min, max, sum, average);
    }
}