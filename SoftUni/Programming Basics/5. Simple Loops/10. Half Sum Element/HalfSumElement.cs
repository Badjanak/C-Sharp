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
            if (current > max)
            {
                max = current;
            }
            sum += current;
        }

        int sumOfOthers = Math.Abs(sum - max);
        if (sumOfOthers == max)
        {
            Console.WriteLine($"yes sum {max}");
        }
        else
        {
            int difference = Math.Abs(sumOfOthers - max);
            Console.WriteLine($"no diff {difference}");
        }
    }
}
