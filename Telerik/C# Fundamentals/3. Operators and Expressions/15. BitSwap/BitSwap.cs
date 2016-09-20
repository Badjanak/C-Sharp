/*
 Write a program first reads 4 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.
 */

using System;

class BitSwap
{
    static void Main()
    {
        uint number = 0u;
        byte close = 0;
        byte far = 0;
        byte k = 0;

        number = uint.Parse(Console.ReadLine());
        close = byte.Parse(Console.ReadLine());
        far = byte.Parse(Console.ReadLine());
        k = byte.Parse(Console.ReadLine());

        if (Math.Min(close, far) + k > Math.Max(close, far))
        {
            Console.WriteLine("Overlapping");
        }
        else if (!(((close + k) <= 32) && ((far + k) <= 32)))
        {
            Console.WriteLine("Out of range");
        }
        else
        {
            uint mask = (1u << k) - 1u;
            uint maskClose = mask << close;
            uint maskFar = mask << far;

            uint closeBits = number & maskClose;
            uint farBits = number & maskFar;

            closeBits = closeBits >> close;
            farBits = farBits >> far;

            number = number & (~maskClose);
            number = number & (~maskFar);

            closeBits = closeBits << far;
            farBits = farBits << close;

            number = number | closeBits;
            number = number | farBits;

            Console.WriteLine("{0}", number);
        }
    }
}