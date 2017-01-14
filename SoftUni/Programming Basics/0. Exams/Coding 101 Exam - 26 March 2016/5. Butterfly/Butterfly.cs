using System;
using System.Text;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char odd = '*';
        char even = '-';
        string upper = "\\ /";
        string lower = "/ \\";
        StringBuilder butterfly = new StringBuilder();

        for (int i = 1; i <= n - 2; i++)
        {
            if (i % 2 != 0)
            {
                butterfly.Append(odd, n - 2).Append(upper).Append(odd, n - 2).Append("\n");
            }
            else
            {
                butterfly.Append(even, n - 2).Append(upper).Append(even, n - 2).Append("\n");
            }
        }
        butterfly.Append(' ', n - 1).Append('@').Append(' ', n - 1).Append("\n");
        for (int i = n - 2; i > 0; i--)
        {
            if (i % 2 != 0)
            {
                butterfly.Append(odd, n - 2).Append(lower).Append(odd, n - 2).Append("\n");
            }
            else
            {
                butterfly.Append(even, n - 2).Append(lower).Append(even, n - 2).Append("\n");
            }
        }
        Console.WriteLine(butterfly);
    }
}