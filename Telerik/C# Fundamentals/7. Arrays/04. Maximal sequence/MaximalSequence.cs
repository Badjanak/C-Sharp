/*
Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
*/

using System;

class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int bestLength = 1;
        int currentLength = 1;
        for (int i = 1; i < n; i++)
        {
            if (array[i - 1] == array[i])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
            }

            if (currentLength > bestLength)
            {
                bestLength = currentLength;
            }
        }
        Console.WriteLine(bestLength);
    }
}