﻿/*
Write a program that reads an integer N from the console 
and prints true if the third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
The counting is done from right to left, meaning 123456's third digit is 4.
 */

using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = number / 100 % 10;
        bool isSeven = thirdDigit == 7;

        Console.WriteLine(isSeven ? "true" : "false {0}", thirdDigit);
    }
}