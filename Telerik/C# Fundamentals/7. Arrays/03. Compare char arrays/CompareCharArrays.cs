/*
Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CompareCharArrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        bool areEqual = true;
        bool firstIsBefore = true;
        int lenght = first.Length;
        if (first.Length != second.Length)
        {
            areEqual = false;
            if (first.Length > second.Length)
            {
                firstIsBefore = false;
            }
            lenght = Math.Min(first.Length, second.Length);
        }

        for (int i = 0; i < lenght; i++)
        {
            if (first[i] > second[i])
            {
                firstIsBefore = false;
                areEqual = false;
                break;
            }
            else if (first[i] < second[i])
            {
                areEqual = false;
                break;
            }
        }

        Console.WriteLine("{0}", areEqual ? "=" : firstIsBefore ? "<" : ">");
    }
}