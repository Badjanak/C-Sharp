/*
Write a program that calculates N! / K! for given N and K.
Use only one loop.
 */

using System;

class FactorialDivision
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        decimal result = 1;
        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine("{0}", result);
    }
}