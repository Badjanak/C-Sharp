/*
 Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
 */

using System;

class NthBit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        byte position = byte .Parse(Console.ReadLine());
        uint bitChecker = 1u << position;

        Console.WriteLine((number & bitChecker) == bitChecker ? "1" : "0");
    }
}