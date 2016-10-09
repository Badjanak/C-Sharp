using System;

class FibonacciNumbers
{
    static void Main()
    {
        int member = int.Parse(Console.ReadLine());

        decimal firstNumber = 0m;
        decimal secondNumber = 1m;
        decimal sum;

        for (int i = 0; i < member; i++)
        {
            if (i == member - 1)
            {
                Console.WriteLine("{0}", firstNumber);
            }
            else
            {
                Console.Write("{0}, ", firstNumber);

                sum = firstNumber + secondNumber;

                firstNumber = secondNumber;
                secondNumber = sum;
            }
        }
    }
}