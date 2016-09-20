/*
 We are given an integer number N (read from the console), 
 a bit value v (read from the console as well) (v = 0 or 1) 
 and a position P (read from the console). 
 Write a sequence of operators (a few lines of C# code) 
 that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. 
 Print the resulting number on the console.
 */

using System;

class ModifyBit
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());

        uint mask = 1u << p;

        if (v == 0)
        {
            n = n & (~mask);
            Console.WriteLine("{0}", n);

        }
        else // (value == 1)
        {
            n = n | mask;
            Console.WriteLine("{0}", n);
        }
    }
}