using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char branch = '*';
        string stem = " | ";
        char space = ' ';

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(
                new string(space, n - i) + new string(branch, i) +
                stem +
                new string(branch, i) + new string(space, n - i)
                );
        }
    }
}