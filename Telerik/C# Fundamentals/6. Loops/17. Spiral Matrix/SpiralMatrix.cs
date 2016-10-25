﻿/*
 Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) 
 and prints a matrix holding the numbers from 1 to N*N in the form of square spiral.
 */

using System;

class SpiralMatrix
{
    static void Main()
    {
        int side = int.Parse(Console.ReadLine());
        int[,] matrix = new int[side, side];

        int column = 0;
        int row = 0;
        // starting from upper left (0,0)
        int length = side;
        // lenght will be decreased by 1 on every second change of direction
        int number = side * side;
        int currentNumber = 1;

        while (currentNumber <= number)
        {
            // Right (>)
            for (int i = 0; i < length; i++)
            {
                matrix[row, column] = currentNumber;
                currentNumber++;
                column++;
            }
            // setting starting point for the new direction
            row++;
            column--;
            // decreasing the lenght for the next 2 directions
            // if the loop enters again, this is second direction switch
            length--;

            // Down (V)
            for (int i = 0; i < length; i++)
            {
                matrix[row, column] = currentNumber;
                currentNumber++;
                row++;
            }
            column--;
            row--;

            // Left (<)
            for (int i = 0; i < length; i++)
            {
                matrix[row, column] = currentNumber;
                currentNumber++;
                column--;
            }
            row--;
            column++;
            // Second direction switch
            length--;

            // Up (A)
            for (int i = 0; i < length; i++)
            {
                matrix[row, column] = currentNumber;
                currentNumber++;
                row--;
            }
            column++;
            row++;
        }
        // Printing the matrix
        for (int r = 0; r < side; r++)
        {
            Console.WriteLine();
            for (int c = 0; c < side; c++)
            {
                Console.Write("{0} ", matrix[r, c]);
            }
        }
        Console.WriteLine();
    }
}