using System;

class LeftAndRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n * 2; i++)
        {
            if (i < n)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            else // i >= n
            {
                rightSum += int.Parse(Console.ReadLine());
            }
        }

        int difference = Math.Abs(leftSum - rightSum);
        if (difference == 0)
        {
            Console.WriteLine($"yes sum {rightSum}");
        }
        else
        {
            Console.WriteLine($"no diff {difference}");
        }
    }
}
