﻿/*
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */

using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long remainder;
        StringBuilder binary = new StringBuilder();

        while (number > 0)
        {
            int index = 0;
            remainder = number % 2;
            binary.Insert(index, remainder);

            number /= 2;
            index++;
        }
        Console.WriteLine(binary);
    }
}