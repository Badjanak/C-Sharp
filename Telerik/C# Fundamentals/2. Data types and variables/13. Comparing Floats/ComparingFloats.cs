/*
Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
*/

using System;

class ComparingFloats
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());

        double difference = Math.Abs(first - second);
        double eps = 0.000001;

        bool isEqual = difference <= eps;
        Console.WriteLine(isEqual ? "true" : "false");
    }
}