/*
 Write a program that outputs The "use" of quotations causes difficulties.
 */

using System;

class QuotesInStrings
{
    static void Main()
    {
        string escaped = "The \"use\" of quotations causes difficulties.";
        string quoted = @"The ""use"" of quotations causes difficulties.";

        // Console.WriteLine($"{quoted}");
        Console.WriteLine($"{escaped}");
    }
}

// http://bgcoder.com/Contests/Practice/Index/313#0