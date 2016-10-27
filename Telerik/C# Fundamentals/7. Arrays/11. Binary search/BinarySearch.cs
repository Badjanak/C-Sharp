/*
Write a program that finds the index of given element X in a sorted array of N integers 
by using the Binary search algorithm.
*/

using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());

        int min = 0;
        int max = n - 1;
        int mid = (min + max) / 2;
        bool isFound = false;
        while (min <= max)
        {
            mid = (min + max) / 2;

            if (x < numbers[mid])
            {
                max = mid - 1;
            }
            else if (x > numbers[mid])
            {
                min = mid + 1;
            }
            else // (x == numbers[mid])
            {
                isFound = true;
                break;
            }
        }
        Console.WriteLine(isFound ? mid : -1);
    }
}