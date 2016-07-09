using System;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}\n{1}", Convert.ToString(n, 16).ToUpper(), Convert.ToString(n, 2));
    }
}