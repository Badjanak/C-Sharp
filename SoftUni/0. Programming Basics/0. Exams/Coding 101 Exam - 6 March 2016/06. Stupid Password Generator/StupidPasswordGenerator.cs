using System;

class StupidPasswordGenerator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int first = 1; first <= n; first++)
        {
            for (int second = 1; second <= n; second++)
            {
                for (int third = 97; third < 97 + l; third++)
                {
                    for (int fourth = 97; fourth < 97 + l; fourth++)
                    {
                        for (int fifth = 1; fifth <= n; fifth++)
                        {
                            if (first < fifth && second < fifth)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", first, second, (char)third, (char)fourth, fifth);
                            }
                        }
                    }
                }
            }
        }
    }
}