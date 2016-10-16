/*
 Write a program that outputs The "use" of quotations causes difficulties.
 */

using System;

class Quotes
{
    static void Main()
    {
        string escaped = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("{0}", escaped);

        // string quoted = @"The ""use"" of quotations causes difficulties.";
        // Console.WriteLine("{0}", quoted);
    }
}