using System;

class SumOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double value = double.Parse(Console.ReadLine());
            sum += value;
        }

        Console.WriteLine(sum);
    }
}