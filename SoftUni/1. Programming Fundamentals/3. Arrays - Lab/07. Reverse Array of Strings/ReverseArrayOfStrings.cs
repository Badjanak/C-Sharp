using System;
using System.Linq;

class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] strings = Console.ReadLine().Split(' ').ToArray();

        Console.WriteLine(string.Join(" ", strings.Reverse()));
    }
}