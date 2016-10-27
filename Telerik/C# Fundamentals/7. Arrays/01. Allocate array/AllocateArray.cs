/*
Write a program that allocates array of N integers, 
initializes each element by its index multiplied by 5 
and the prints the obtained array on the console. 
*/

using System;

class AllocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i * 5;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}