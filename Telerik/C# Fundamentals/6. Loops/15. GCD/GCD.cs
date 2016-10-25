/*
Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
Use the Euclidean algorithm (find it in Internet).
 */

using System;

class GCD
{
    static void Main()
    {
        string nums = Console.ReadLine();
        string[] numbers = nums.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
        int bigger = int.Parse(numbers[0]);
        int lesser = int.Parse(numbers[1]);

        if (lesser > bigger)
        {
            int swap = lesser;
            lesser = bigger;
            bigger = swap;
        }

        int divisor = (bigger % lesser);
        while (divisor != 0)
        {
            bigger = lesser;
            lesser = divisor;
            divisor = bigger % lesser;
        }

        Console.WriteLine("{0}", lesser);
    }
}