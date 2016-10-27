/*
Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        // Kadane’s Algorithm
        int maxSum = numbers[0];
        int currentSum = numbers[0];
        for (int i = 0; i < n; i++)
        {
            currentSum = Math.Max(numbers[i], currentSum + numbers[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        Console.WriteLine(maxSum);
    }
}