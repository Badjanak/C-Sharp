using System;

class OddEvenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal oddSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        decimal evenSum = 0;

        for (int i = 1; i <= n; i++)
        {
            decimal currentNumber = decimal.Parse(Console.ReadLine());

            if (i % 2 != 0)
            {
                if (currentNumber < oddMin)
                {
                    oddMin = currentNumber;
                }
                if (currentNumber > oddMax)
                {
                    oddMax = currentNumber;
                }
                oddSum += currentNumber;
            }
            if (i % 2 == 0)
            {
                if (currentNumber < evenMin)
                {
                    evenMin = currentNumber;
                }
                if (currentNumber > evenMax)
                {
                    evenMax = currentNumber;
                }
                evenSum += currentNumber;
            }
        }

        if (n == 0)
        {
            Console.WriteLine($"OddSum={oddSum}, OddMin=No, OddMax=No, EvenSum={evenSum}, EvenMin=No, EvenMax=No");
        }
        else if (n == 1)
        {
            Console.WriteLine($"OddSum={oddSum:0.##}, OddMin={oddMin:0.##}, OddMax={oddMax:0.##}, EvenSum={evenSum}, EvenMin=No, EvenMax=No");
        }
        else
        {
            Console.WriteLine($"OddSum={oddSum:0.##}, OddMin={oddMin:0.##}, OddMax={oddMax:0.##}, EvenSum={evenSum:0.##}, EvenMin={evenMin:0.##}, EvenMax={evenMax:0.##}");
        }
    }
}
