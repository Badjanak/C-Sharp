using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += int.Parse(Console.ReadLine());
            }
            else
            {
                oddSum += int.Parse(Console.ReadLine());
            }
        }

        int difference = Math.Abs(oddSum - evenSum);
        if (difference == 0)
        {
            Console.WriteLine($"yes sum {evenSum}");
        }
        else
        {
            Console.WriteLine($"no diff {difference}");
        }
    }
}
