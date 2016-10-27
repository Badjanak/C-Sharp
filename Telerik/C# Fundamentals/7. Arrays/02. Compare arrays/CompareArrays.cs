/*
Write a program that reads two integer arrays of size N from the console and compares them element by element.
*/

using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] first = new int[n];
        for (int i = 0; i < n; i++)
        {
            first[i] = int.Parse(Console.ReadLine());
        }

        int[] second = new int[n];
        for (int i = 0; i < n; i++)
        {
            second[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        for (int i = 0; i < n; i++)
        {
            if (first[i] != second[i])
            {
                areEqual = false;
                break;
            }
        }

        Console.WriteLine("{0}", areEqual ? "Equal" : "Not equal");
    }
}