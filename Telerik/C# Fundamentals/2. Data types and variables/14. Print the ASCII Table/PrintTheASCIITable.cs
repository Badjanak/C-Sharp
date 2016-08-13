/*
 Write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including)
 */

using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (int code = 33; code <= 126; code++)
        {
            char symbol = (char)code;
            Console.Write($"{symbol}");
        }
    }
}

// http://bgcoder.com/Contests/Practice/Index/313#2