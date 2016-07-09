using System;

class FilledSquare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintFirstLastRow(n);
        PrintMiddleRow(n);
        PrintFirstLastRow(n);
    }

    static void PrintFirstLastRow(int n)
    {
        string row = new string('-', 2 * n);
        Console.WriteLine(row);
    }

    static void PrintMiddleRow(int n)
    {
        string beginEnd = "-";
        string fill = "\\/";

        string row = beginEnd;
        for (int i = 0; i < n - 1; i++)
        {
            row += fill;
        }
        row += beginEnd;

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(row);
        }
    }
}