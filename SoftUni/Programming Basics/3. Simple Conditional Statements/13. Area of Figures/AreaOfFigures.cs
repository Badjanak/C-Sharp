using System;

class AreaOfFigures
{
    static void Main()
    {
        string figure = Console.ReadLine();

        double area = 0;
        if (figure.Equals("square"))
        {
            double side = double.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (figure.Equals("circle"))
        {
            double radius = double.Parse(Console.ReadLine());
            area = radius * radius * Math.PI;
        }
        else if (figure.Equals("rectangle"))
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            area = width * length;
        }
        else if (figure.Equals("triangle"))
        {
            double baseSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            area = baseSide * height / 2;
        }
        else
        {
            Console.WriteLine("No such figure!");
        }

        Console.WriteLine("{0:0.###}", area);
    }
}
