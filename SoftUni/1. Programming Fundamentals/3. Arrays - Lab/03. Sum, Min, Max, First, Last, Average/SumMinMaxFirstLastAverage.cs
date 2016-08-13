using System;
using System.Linq;

class SumMinMaxFirstLastAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] integers = new int[n];
        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            integers[i] = current;
        }

        Console.WriteLine("Sum = {0}\nMin = {1}\nMax = {2}\nFirst = {3}\nLast = {4}\nAverage = {5}",
            integers.Sum(), integers.Min(), integers.Max(), integers.First(), integers.Last(), integers.Average());
    }
}