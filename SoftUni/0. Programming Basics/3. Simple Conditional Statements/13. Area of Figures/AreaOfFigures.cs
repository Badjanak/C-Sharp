using System;

class AreaOfFigures
{
    static void Main()
    {
        string figure = Console.ReadLine();
        decimal area = 0;

        if (figure.Equals("square"))
        {
            decimal side = decimal.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (figure.Equals("circle"))
        {
            decimal radius = decimal.Parse(Console.ReadLine());
            area = radius * radius * (decimal)Math.PI;
        }
        else if (figure.Equals("rectangle"))
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());
            area = width * length;
        }
        else if (figure.Equals("triangle"))
        {
            decimal baseSide = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            area = baseSide * height / 2;
        }
        else
        {
            Console.WriteLine("No such figure!");
        }

        Console.WriteLine("{0:0.###}", area);
    }
}