using System;

class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            sum += current;
            if (current > max)
            {
                max = current;
            }
        }

        int difference = Math.Abs(sum - max);
        if (difference == max)
        {
            Console.WriteLine("yes sum {0}", max);
        }
        else
        {
            Console.WriteLine("no diff {0}", Math.Abs(difference - max));
        }
    }
}