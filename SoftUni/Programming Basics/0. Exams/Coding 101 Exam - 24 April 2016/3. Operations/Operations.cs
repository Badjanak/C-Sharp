using System;

class Operations
{
    static void Main()
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        string math = Console.ReadLine();

        if (n2 == 0)
        {
            Console.WriteLine("Cannot divide {0} by zero", n1);
        }
        else
        {
            switch (math)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, math, n2, n1 + n2, (n1 + n2) % 2 == 0 ? "even" : "odd");
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, math, n2, n1 - n2, (n1 - n2) % 2 == 0 ? "even" : "odd");
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, math, n2, n1 * n2, (n1 * n2) % 2 == 0 ? "even" : "odd");
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3:0.00}", n1, math, n2, n1 / n2);
                    break;
                case "%":
                    Console.WriteLine("{0} {1} {2} = {3}", n1, math, n2, n1 % n2);
                    break;
                default:
                    break;
            }
        }
    }
}