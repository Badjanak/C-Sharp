using System;

class EvenPowersOf2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        for (int i = 0; i <= n; i += 2)
        {
            Console.WriteLine(number);
            number *= 4;
        }
    }
}