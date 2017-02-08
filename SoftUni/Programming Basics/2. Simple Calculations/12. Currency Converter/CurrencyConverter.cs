using System;

class CurrencyConverter
{
    static void Main()
    {
        decimal BGN = 1;
        decimal USD = 1.79549m;
        decimal EUR = 1.95583m;
        decimal GBP = 2.53405m;

        decimal sum = decimal.Parse(Console.ReadLine());
        string givenCurrency = Console.ReadLine();
        string takenCurrency = Console.ReadLine();

        decimal value = sum;
        switch (givenCurrency)
        {
            case "BGN":
                value *= BGN;
                break;
            case "USD":
                value *= USD;
                break;
            case "EUR":
                value *= EUR;
                break;
            case "GBP":
                value *= GBP;
                break;
            default:
                Console.WriteLine("No such currency");
                break;
        }
        //Console.WriteLine(money);
        switch (takenCurrency)
        {
            case "BGN":
                value /= BGN;
                break;
            case "USD":
                value /= USD;
                break;
            case "EUR":
                value /= EUR;
                break;
            case "GBP":
                value /= GBP;
                break;
            default:
                Console.WriteLine("No such currency");
                break;
        }

        Console.WriteLine($"{value:0.##}");
    }
}
