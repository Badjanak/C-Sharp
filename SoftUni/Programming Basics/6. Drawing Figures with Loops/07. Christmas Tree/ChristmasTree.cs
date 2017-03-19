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
            string leftBranch = new string(space, n - i) + new string(branch, i);
            string rightBranch = new string(branch, i) + new string(space, n - i);
            Console.WriteLine($"{leftBranch}{stem}{rightBranch}");
        }
    }
}