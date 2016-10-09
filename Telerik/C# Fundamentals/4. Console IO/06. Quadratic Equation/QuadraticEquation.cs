using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        //Calculating the discriminant of the square root
        double discriminant = (b * b) - 4 * a * c;

        if (discriminant < 0)
        {
            //There is no solution
            Console.WriteLine("no real roots");
        }
        else
        {

            double discriminantRoot = Math.Sqrt(discriminant);
            double x1 = (-b + discriminantRoot) / (2.0 * a);
            double x2 = (-b - discriminantRoot) / (2.0 * a);
            // if there is only one solution, both x's will be the same
            if (x1 == x2)
            {
                Console.WriteLine("{0:f2}", x1);
            }
            else
            {
                Console.WriteLine(x1 < x2 ? "{0:f2}\n{1:f2}" : "{1:f2}\n{0:f2}", x1, x2);
            }
        }
    }
}