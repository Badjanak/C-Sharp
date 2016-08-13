using System;

class LastKNumbersSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];
        numbers[0] = 1;

        for (int i = 1; i < n; i++)
        {
            int start = Math.Max(0, i - k);
            int end = i - 1;
            long sum = 0;

            for (int j = start; j <= end; j++)
            {
                sum += numbers[j];
            }
            numbers[i] = sum;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}