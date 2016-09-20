/*
Write a program that reads an integer N (which will always be less than 100 or equal) 
and uses an expression to check if given N is prime 
(i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
 */

using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool check = 0 < number && number >= 100;
        bool isPrime = (number == 1 || number == 2 || number == 3 || number == 5 || number == 7) ^
            (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0);

        if (check)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("{0}", isPrime ? "true" : "false");
        }
    }
}