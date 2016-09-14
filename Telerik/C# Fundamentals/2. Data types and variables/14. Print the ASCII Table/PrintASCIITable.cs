/*
 Find online more information about ASCII (American Standard Code for Information Interchange) 
 and write a program that prints the visible characters of the ASCII table on the console 
 (characters from 33 to 126 including).
 */

using System;

class PrintASCIITable
{
    static void Main()
    {
        for (int code = 33; code <= 126; code++)
        {
            char symbol = (char)code;
            Console.Write("{0}", symbol);
        }
    }
}