using System;
using System.Text;

class Stop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char underscore = '_';
        StringBuilder stop = new StringBuilder();

        stop.Append(dot, n + 1).Append(underscore, n * 2 + 1).Append(dot, n + 1).Append("\n");

        for (int i = n, f = n * 2 - 1; i > 0; i--, f += 2)
        {
            stop.Append(dot, i).Append("//").Append(underscore, f).Append("\\\\").Append(dot, i).Append("\n");
        }

        stop.Append("//").Append(underscore, n * 2 - 3).Append("STOP!").Append(underscore, n * 2 - 3).Append("\\\\").Append("\n");

        for (int i = 0, f = n * 4 - 1; i < n; i++, f -= 2)
        {
            stop.Append(dot, i).Append("\\\\").Append(underscore, f).Append("//").Append(dot, i).Append("\n");
        }

        Console.WriteLine(stop);
    }
}