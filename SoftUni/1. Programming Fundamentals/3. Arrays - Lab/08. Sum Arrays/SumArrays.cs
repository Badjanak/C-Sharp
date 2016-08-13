using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int length = Math.Max(first.Length, second.Length);
        int[] result = new int[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = first[i % first.Length] + second[i % second.Length];
        }

        Console.WriteLine(string.Join(" ", result));
    }
}