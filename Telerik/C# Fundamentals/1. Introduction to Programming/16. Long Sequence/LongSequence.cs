/*
Write a program that prints the first 1000 members of the sequence: 
2, -3, 4, -5, 6, -7, …
*/

using System;

class LongSequence
{
    static void Main()
    {
        int start = 2;
        int membersCount = 1000;
        int end = start + membersCount;

        for (int index = start; index < end; index++)
        {
            if (index % 2 == 0) // index is even
            {
                Console.WriteLine(index);
            }
            else if (index % 2 != 0) // index is odd
            {
                Console.WriteLine(-index);
            }
        }
    }
}