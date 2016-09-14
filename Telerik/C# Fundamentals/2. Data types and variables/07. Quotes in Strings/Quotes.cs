/*
 Write a program that outputs The "use" of quotations causes difficulties.
 */

using System;

class Quotes
{
    static void Main()
    {
        string escaped = "The \"use\" of quotations causes difficulties.";
        string quoted = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine($"{escaped}");
        // Console.WriteLine($"{quoted}");
    }
}