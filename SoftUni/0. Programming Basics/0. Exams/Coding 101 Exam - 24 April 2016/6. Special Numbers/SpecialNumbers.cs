using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int a = 1; a < 10; a++)
        {
            for (int b = 1; b < 10; b++)
            {
                for (int c = 1; c < 10; c++)
                {
                    for (int d = 1; d < 10; d++)
                    {
                        int currentNumber = a * 1000 + b * 100 + c * 10 + d;
                        bool isSpecial = (n % a == 0) && (n % b == 0) && (n % c == 0) && (n % d == 0);
                        if (isSpecial)
                        {
                            Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                        }
                    }
                }
            }
        }
    }
}