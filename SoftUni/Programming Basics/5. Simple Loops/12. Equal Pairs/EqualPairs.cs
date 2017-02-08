using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        int sum = first + second;
        int maxDiff = 0;

        for (int i = 1; i < n; i++)
        {
            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());

            int currentSum = first + second;
            int currentDiff = Math.Abs(currentSum - sum);
            if (currentDiff > maxDiff)
            {
                maxDiff = currentDiff;
            }
            sum = currentSum;
        }

        if (maxDiff == 0)
        {
            Console.WriteLine($"Yes, value={sum}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}
