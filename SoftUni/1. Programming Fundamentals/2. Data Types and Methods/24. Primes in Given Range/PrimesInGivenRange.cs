using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        List<int> foundPrimes = FindPrimesInRange(start, end);

        string result = string.Join(", ", foundPrimes);
        Console.WriteLine(result);
    }

    static List<int> FindPrimesInRange(int start, int end)
    {
        List<int> primes = new List<int>();
        if (start < 2)
        {
            start = 2;
        }
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    static bool IsPrime(long n)
    {
        bool isPrime = true;

        if (n == 0 || n == 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        return isPrime;
    }
}