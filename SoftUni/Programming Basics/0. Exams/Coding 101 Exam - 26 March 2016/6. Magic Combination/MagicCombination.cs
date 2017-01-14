using System;

class MagicCombination
{
    static void Main()
    {
        int magicNumber = int.Parse(Console.ReadLine());

        for (int a = 1; a < 10; a++)
        {
            for (int b = 1; b < 10; b++)
            {
                for (int c = 1; c < 10; c++)
                {
                    for (int d = 1; d < 10; d++)
                    {
                        for (int e = 1; e < 10; e++)
                        {
                            for (int f = 1; f < 10; f++)
                            {
                                if ((a * b * c * d * e * f) == magicNumber)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", a, b, c, d, e, f);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}