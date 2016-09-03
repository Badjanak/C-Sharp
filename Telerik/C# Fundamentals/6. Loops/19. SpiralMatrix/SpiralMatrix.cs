/*
 * Write a program that reads from the console a positive integer number n (1 = n = 20) 
 * and prints a matrix holding the numbers from 1 to n*n 
 * in the form of square spiral like in the examples below.
 * Examples:
n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1  2  3  4
        4 3                 8 9 4               12 13 14 5
                            7 6 5               11 16 15 6
                                                10 9  8  7
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
                Console.Write("{0,3}", matrix[r, c]);
            }
        }
        Console.WriteLine();
    }
}
