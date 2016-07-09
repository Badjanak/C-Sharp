using System;

class NumbersInReversedOrder
{
    static void Main()
    {
        string n = Console.ReadLine();
        ReverseOrder(n);
    }

    static void ReverseOrder(string number)
    {
        char[] result = number.ToCharArray();
        Array.Reverse(result);
        Console.WriteLine(new string(result));
    }
}