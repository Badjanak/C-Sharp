using System;

class EvenOrOdd
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isEven = number % 2 == 0;
        Console.WriteLine("{0}", isEven
            ? "even"
            : "odd");
    }
}
