using System;

class NumbersComparer
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}", first > second ? first : second);

        /*
        Using Math class

        // With Math.Max
        double max = Math.Max(first, second);
        Console.WriteLine("{0}", max);

        // With Math.Abs
        double absMax = ((first + second + Math.Abs(first - second)) / 2);
        Console.WriteLine("{0}", absMax);
        
        */
    }
}