/*
In combinatorics, the number of ways to choose N different members out of a group of N different elements 
(also known as the number of combinations) 
Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.
Try to use only two loops.
 */

using System;
using System.Numerics;

class Combinatorics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger fact1 = 1;
        BigInteger fact2 = 1;

        // N!/K!
        for (int i = k + 1; i <= n; i++)
        {
            fact1 *= i;
        }
        // (N-K)!
        for (int j = 1; j <= (n - k); j++)
        {
            fact2 *= j;
        }

        BigInteger result = fact1 / fact2;

        Console.WriteLine("{0}", result);
    }
}