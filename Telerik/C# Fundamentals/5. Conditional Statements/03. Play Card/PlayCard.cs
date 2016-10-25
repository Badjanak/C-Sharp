/*
 Classical play cards use the following signs to designate the card face: 
 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 Write a program that enters a string 
 and prints "yes CONTENT_OF_STRING" if it is a valid card sign 
 or "no CONTENT_OF_STRING" otherwise.
 */

using System;

class PlayCard
{
    static void Main()
    {
        string sign = Console.ReadLine();

        bool isNumeral;
        bool isChar;
        byte numeralSign;
        char charSign;

        isNumeral = byte.TryParse(sign, out numeralSign);
        isChar = char.TryParse(sign, out charSign);

        if (isNumeral)
        {
            switch (numeralSign)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("yes {0}", sign);
                    break;
                default:
                    Console.WriteLine("no {0}", sign);
                    break;
            }
        }
        else if (isChar)
        {
            switch (charSign)
            {
                case 'J':
                case 'Q':
                case 'K':
                case 'A':
                    Console.WriteLine("yes {0}", sign);
                    break;
                default:
                    Console.WriteLine("no {0}", sign);
                    break;
            }
        }
        else
        {
            Console.WriteLine("no {0}", sign);
        }
    }
}