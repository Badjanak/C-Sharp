using System;

class TradeComissions
{
    static void Main()
    {
        string town = Console.ReadLine().ToLower();
        decimal sales = decimal.Parse(Console.ReadLine());

        decimal commission = 0;
        if (town.Equals("sofia"))
        {
            if (0 <= sales && sales <= 500)
            {
                commission = 0.05m;
            }
            else if (500 < sales && sales <= 1000)
            {
                commission = 0.07m;
            }
            else if (1000 < sales && sales <= 10000)
            {
                commission = 0.08m;
            }
            else if (sales > 10000)
            {
                commission = 0.12m;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town.Equals("varna"))
        {
            if (0 <= sales && sales <= 500)
            {
                commission = 0.045m;
            }
            else if (500 < sales && sales <= 1000)
            {
                commission = 0.075m;
            }
            else if (1000 < sales && sales <= 10000)
            {
                commission = 0.1m;
            }
            else if (sales > 10000)
            {
                commission = 0.13m;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town.Equals("plovdiv"))
        {
            if (0 <= sales && sales <= 500)
            {
                commission = 0.055m;
            }
            else if (500 < sales && sales <= 1000)
            {
                commission = 0.08m;
            }
            else if (1000 < sales && sales <= 10000)
            {
                commission = 0.12m;
            }
            else if (sales > 10000)
            {
                commission = 0.145m;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        Console.WriteLine($"{commission * sales:0.00}");
    }
}
