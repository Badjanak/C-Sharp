using System;

class ComparingFloats
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());

        double difference = Math.Abs(first - second);
        double eps = 0.000001;

        bool areEqual = difference <= eps;

        Console.WriteLine(areEqual);
    }
}