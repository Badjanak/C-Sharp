using System;

class PoolPipes
{
    static void Main()
    {
        double volume = double.Parse(Console.ReadLine());
        double capacity1 = double.Parse(Console.ReadLine());
        double capacity2 = double.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double pool = (capacity1 + capacity2) * hours;
        bool isOverflowed = pool > volume;
        if (isOverflowed)
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, pool - volume);
        }
        else
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1:}%. Pipe 2: {2}%.", (int)(pool / volume * 100), (int)(capacity1 * hours / pool * 100), (int)(capacity2 * hours / pool * 100));
        }
    }
}