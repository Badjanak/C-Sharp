/*
 Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */

using System;

class PrintSequence
{
    static void Main()
    {
        int start = 2;
        int members = 10;

        for (int i = start; i < start + members; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}

// http://bgcoder.com/Contests/Practice/Index/314#3