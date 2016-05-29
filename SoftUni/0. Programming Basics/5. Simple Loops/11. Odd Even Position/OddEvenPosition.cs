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
            Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No");
        }
        else if (n == 1)
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=0, EvenMin=No, EvenMax=No",
                oddSum, oddMin, oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}",
                oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}