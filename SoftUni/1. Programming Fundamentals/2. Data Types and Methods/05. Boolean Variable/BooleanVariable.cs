using System;

class BooleanVariable
{
    static void Main()
    {
        string input = Console.ReadLine();
        bool isBoolean = Convert.ToBoolean(input);

        Console.WriteLine(isBoolean ? "Yes" : "No");
    }
}