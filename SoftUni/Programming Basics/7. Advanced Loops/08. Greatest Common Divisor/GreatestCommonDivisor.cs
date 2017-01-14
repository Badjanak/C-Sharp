using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        int temp = second;
        // Swap numbers to ensure first is greater
        if (first < second)
        {
            second = first;
            first = temp;
        }
        // Euclidean algorithm
        while (second != 0)
        {
            temp = second;
            second = first % second;
            first = temp;
        }
        Console.WriteLine(first);
    }
}