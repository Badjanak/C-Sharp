using System;

class CheckPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine("{0}", isPrime ? "Prime" : "Not Prime");
    }
}