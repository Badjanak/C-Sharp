using System;

class EnterEvenNumber
{
    static void Main()
    {
        bool isEven = false;
        int n = 1;
        while (!isEven)
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                isEven = n % 2 == 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
        }
        Console.WriteLine(n);
    }
}