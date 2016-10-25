/*
Write a program that reads from the console a positive integer number N 
and prints a matrix like in the examples below. Use two nested loops.
Challenge: achieve the same effect without nested loops
 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int coll = 0; coll < n; coll++)
            {
                Console.Write("{0} ", coll + row);
            }
            Console.WriteLine();
        }
    }
}