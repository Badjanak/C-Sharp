/*
 Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
 */

using System;

class NthBit
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        int position = int.Parse(Console.ReadLine());
        long bitChecker = 1L << position;

        Console.WriteLine((number & bitChecker) == bitChecker ? "1" : "0");
    }
}