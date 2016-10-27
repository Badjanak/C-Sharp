/*
Sorting an array means to arrange its elements in increasing order. 
Write a program to sort an array. 
Use the Selection sort algorithm: 
Find the smallest element, move it at the first position, 
find the smallest from the rest, move it at the second position, etc.
*/

using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int index = 0; index < n - 1; index++)
        {
            int smallest = index;

            for (int search = index + 1; search < n; search++)
            {
                if (numbers[smallest] > numbers[search])
                {
                    smallest = search;
                }
            }

            int swap = numbers[index];
            numbers[index] = numbers[smallest];
            numbers[smallest] = swap;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}