/*
Write a program to calculate the Nth Catalan number by given N
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger divident = 1;
        for (int i = 2 * n; i > n + 1; i--)
        {
            divident *= i;
        }
        BigInteger divider = 1;
        for (int i = 1; i <= n; i++)
        {
            divider *= i;
        }

        BigInteger result = divident / divider;
        Console.WriteLine("{0}", result);
    }
}