using System;

class MaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber > max)
            {
                max = currentNumber;
            }
        }

        Console.WriteLine(max);
    }
}
