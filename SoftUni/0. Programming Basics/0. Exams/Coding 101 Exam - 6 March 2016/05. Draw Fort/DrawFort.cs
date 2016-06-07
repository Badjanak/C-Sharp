using System;
using System.Text;

class DrawFort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mid = n / 2;
        StringBuilder fort = new StringBuilder();
        // Top
        fort.Append('/').Append('^', n / 2).Append('\\').Append('_', 2 * n - 4 - 2 * (n / 2)).Append('/').Append('^', n / 2).Append('\\').Append("\n");
        // Middle
        for (int i = 0; i < n - 3; i++)
        {
            fort.Append('|').Append(' ', 2 * n - 2).Append('|').Append("\n");
        }
        // Bottom
        fort.Append('|').Append(' ', n / 2 + 1).Append('_', 2 * n - 4 - 2 * (n / 2)).Append(' ', n / 2 + 1).Append('|').Append("\n");

        fort.Append('\\').Append('_', n / 2).Append('/').Append(' ', 2 * n - 4 - 2 * (n / 2)).Append('\\').Append('_', n / 2).Append('/');
        Console.WriteLine(fort);
    }
}