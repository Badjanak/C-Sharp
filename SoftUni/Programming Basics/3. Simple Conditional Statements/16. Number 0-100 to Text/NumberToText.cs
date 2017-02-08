using System;

class NumberToText
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        // Check border cases
        if (0 > number || number > 100)
        {
            Console.WriteLine("Nmber out of range [0-100]");
        }
        else if (number == 100)
        {
            Console.WriteLine("one hundred");
        }
        else if (number == 0)
        {
            Console.WriteLine("zero");
        }

        else
        {
            int ones = number % 10;
            int tens = (number / 10) % 10;

            // From 10 to 20
            if (tens == 1)
            {
                switch (ones)
                {
                    case 0:
                        Console.WriteLine("ten");
                        break;
                    case 1:
                        Console.WriteLine("eleven");
                        break;
                    case 2:
                        Console.WriteLine("twelve");
                        break;
                    case 3:
                        Console.WriteLine("thirteen");
                        break;
                    case 4:
                        Console.WriteLine("fourteen");
                        break;
                    case 5:
                        Console.WriteLine("fifteen");
                        break;
                    case 6:
                        Console.WriteLine("sixteen");
                        break;
                    case 7:
                        Console.WriteLine("seventeen");
                        break;
                    case 8:
                        Console.WriteLine("eighteen");
                        break;
                    case 9:
                        Console.WriteLine("nineteen");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            // Above 20
            if (tens > 1)
            {
                switch (tens)
                {
                    case 2:
                        Console.Write("twenty");
                        break;
                    case 3:
                        Console.Write("thirty");
                        break;
                    case 4:
                        Console.Write("fourty");
                        break;
                    case 5:
                        Console.Write("fifty");
                        break;
                    case 6:
                        Console.Write("sixty");
                        break;
                    case 7:
                        Console.Write("seventy");
                        break;
                    case 8:
                        Console.Write("eighty");
                        break;
                    case 9:
                        Console.Write("ninety");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                // Leave space in case there is ones to print
                if (ones != 0)
                {
                    Console.Write(" ");
                }
            }
            // Set ones in cases tens are under 10 or above 19
            if (tens != 1)
            {
                switch (ones)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
