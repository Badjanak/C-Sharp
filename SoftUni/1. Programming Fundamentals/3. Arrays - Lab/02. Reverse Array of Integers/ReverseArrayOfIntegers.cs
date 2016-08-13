using System;

class ReverseArrayOfIntegers
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

        int[] reversed = new int[n];
        for (int i = 0; i < n; i++)
        {
            reversed[i] = integers[n - 1 - i];
        }

        Console.WriteLine(string.Join(" ", reversed));
    }
}