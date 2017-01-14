using System;

class ThreeEqualNumbers
{
    static void Main()
    {
        decimal first = decimal.Parse(Console.ReadLine());
        decimal second = decimal.Parse(Console.ReadLine());
        decimal third = decimal.Parse(Console.ReadLine());

        if ((first == second) && (second == third))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}