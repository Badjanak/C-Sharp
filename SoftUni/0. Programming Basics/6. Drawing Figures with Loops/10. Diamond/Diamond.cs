using System;
using System.Text;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char wall = '*';
        char space = '-';
        StringBuilder diamond = new StringBuilder();

        int top = 1;
        bool isEven = n % 2 == 0;
        if (isEven)
        {
            top = 2;
        }


    }
}