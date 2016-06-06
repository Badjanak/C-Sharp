using System;
using System.Text;

class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char star = '*';
        char space = ' ';

        string rhombus = "";
        for (int rows = 1; rows <= n; rows++)
        {
            rhombus += new string(space, n - rows);
            rhombus += star;
            for (int i = 0; i < rows - 1; i++)
            {
                rhombus += " *";
            }
            rhombus += new string(space, n - rows);
            rhombus += "\r\n";
        }

        for (int rows = n - 1; rows >= 1; rows--)
        {
            rhombus += new string(space, n - rows);
            rhombus += star;
            for (int i = 0; i < rows - 1; i++)
            {
                rhombus += " *";
            }
            rhombus += new string(space, n - rows);
            rhombus += "\r\n";
        }
        Console.WriteLine(rhombus);
    }
}