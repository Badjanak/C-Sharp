using System;
using System.Text;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char fill = '*';
        char wall = '|';
        char space = '-';
        StringBuilder house = new StringBuilder();

        int roofTop = 1;
        bool isEven = n % 2 == 0;
        if (isEven)
        {
            roofTop = 2;
        }
        // Roof
        for (int i = roofTop; i < n + 1 / 2; i += 2)
        {
            house.Append(space, (n - i) / 2);
            house.Append(fill, i);
            house.Append(space, (n - i) / 2);
            house.Append("\n");
        }
        // Middle
        house.Append(fill, n);
        house.Append("\n");
        // Bottom
        for (int i = 0; i < n / 2; i++)
        {
            house.Append(wall, 1);
            house.Append(fill, n - 2);
            house.Append(wall, 1);
            house.Append("\n");
        }

        Console.WriteLine(house);
    }
}