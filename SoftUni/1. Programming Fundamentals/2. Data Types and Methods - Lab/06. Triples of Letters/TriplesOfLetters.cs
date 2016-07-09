using System;

class TriplesOfLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int a = 'a'; a < 'a' + n; a++)
        {
            for (int b = 'a'; b < 'a' + n; b++)
            {
                for (int c = 'a'; c < 'a' + n; c++)
                {
                    Console.WriteLine("{0}{1}{2}", (char)a, (char)b, (char)c);
                }
            }
        }
    }
}