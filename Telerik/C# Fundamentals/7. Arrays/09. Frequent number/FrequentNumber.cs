/*
Write a program that finds the most frequent number in an array of N elements.
*/

using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        int bestLength = 1;
        int currentLength = 1;
        int number = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i - 1] == numbers[i])
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
                number = numbers[i];
            }
        }

        Console.WriteLine("{0} ({1} times)", number, bestLength);
    }
}