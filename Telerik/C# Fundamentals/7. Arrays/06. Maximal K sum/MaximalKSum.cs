/*
Write a program that reads two integer numbers N and K and an array of N elements from the console. 
Find the maximal sum of K elements in the array.
*/

using System;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        int bestSum = 0;
        for (int i = n - 1; i > n - 1 - k; i--)
        {
            bestSum += array[i];
        }

        Console.WriteLine(bestSum);
    }
}