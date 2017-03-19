using System;
using System.Text;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char wall = '*';
        char space = '-';
        StringBuilder diamond = new StringBuilder();

        bool isEven = n % 2 == 0;
        int start = 1;
        if (isEven)
        {
            start = 2;
        }
        int inner = start;
        int mid = (n - 1) / 2;

        if (n < 3)
        {
            diamond.Append(wall, start);
        }
        else
        {
            diamond.Append(space, mid).Append(wall, start).Append(space, mid).Append("\n");
            for (int outer = mid - 1; outer >= 0; outer--, inner += 2)
            {
                diamond.Append(space, outer).Append(wall, 1).Append(space, inner).Append(wall, 1).Append(space, outer).Append("\n");
            }
            inner -= 4; // Decrease value and set start fo lower part
            for (int outer = 1; outer < mid; outer++, inner -= 2)
            {
                diamond.Append(space, outer).Append(wall, 1).Append(space, inner).Append(wall, 1).Append(space, outer).Append("\n");
            }
            diamond.Append(space, mid).Append(wall, start).Append(space, mid);
        }
        Console.WriteLine(diamond);
    }
}