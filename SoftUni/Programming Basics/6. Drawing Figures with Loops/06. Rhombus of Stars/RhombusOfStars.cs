using System;
using System.Text;

class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char space = ' ';
        
        // Upper part
        for (int rows = 1; rows <= n; rows++)
        {
            string fill = new string(space, n - rows);
            string rhombus = "*";
            for (int i = 0; i < rows-1; i++)
            {
                rhombus += " *";
            }
            Console.WriteLine($"{fill}{rhombus}{fill}");
        }
        // Lower part
        for (int rows = n - 1; rows >= 1; rows--)
        {
            string fill = new string(space, n - rows);
            string rhombus = "*";
            for (int i = 0; i < rows - 1; i++)
            {
                rhombus += " *";
            }
            Console.WriteLine($"{fill}{rhombus}{fill}");
        }
    }
}