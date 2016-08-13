using System;
using System.Linq;

class RoundingNumbers
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        int[] rounded = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            rounded[i] = (int)(Math.Round(numbers[i], MidpointRounding.AwayFromZero));

            Console.WriteLine($"{numbers[i]} => {rounded[i]}");
        }
    }
}