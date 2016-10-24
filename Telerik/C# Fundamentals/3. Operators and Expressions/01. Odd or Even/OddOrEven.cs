/*
 Write a program that reads an integer from the console, 
 uses an expression to check if given integer is odd or even, 
 and prints "even NUMBER" or "odd NUMBER", 
 where you should print the input number's value instead of NUMBER.
 */

using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isEven = number % 2 == 0;

        Console.WriteLine(isEven ? "even {0}" : "odd {0}", number);
    }
}