using System;

class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char edge = '+';
        char frame = '|';

        string inner = " ";
        for (int i = 0; i < n - 2; i++)
        {
            inner += "- ";
        }
        // Console.WriteLine(inner);

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.WriteLine($"{edge}{inner}{edge}");
            }
            else
            {
                Console.WriteLine($"{frame}{inner}{frame}");
            }
        }
    }
}