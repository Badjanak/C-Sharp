using System;
using System.Linq;

class ExtractMiddleElements
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (numbers.Length == 1)
        {
            Console.WriteLine($"{numbers[0]}");
        }
        else
        {
            bool isEven = numbers.Length % 2 == 0;
            int length = numbers.Length / 2;
            if (isEven)
            {
                Console.WriteLine($"{numbers[length - 1]} {numbers[length]}");
            }
            else
            {
                Console.WriteLine($"{numbers[length - 1]} {numbers[length]} {numbers[length + 1]}");
            }
        }
    }
}