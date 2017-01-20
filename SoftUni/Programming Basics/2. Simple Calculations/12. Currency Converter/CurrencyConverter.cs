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

        decimal money = sum;
        switch (givenCurrency)
        {
            case "BGN":
                money *= BGN;
                break;
            case "USD":
                money *= USD;
                break;
            case "EUR":
                money *= EUR;
                break;
            case "GBP":
                money *= GBP;
                break;
            default:
                Console.WriteLine("No such currency");
                break;
        }
        //Console.WriteLine(money);
        switch (takenCurrency)
        {
            case "BGN":
                money /= BGN;
                break;
            case "USD":
                money /= USD;
                break;
            case "EUR":
                money /= EUR;
                break;
            case "GBP":
                money /= GBP;
                break;
            default:
                Console.WriteLine("No such currency");
                break;
        }

        Console.WriteLine($"{money:0.##}");
    }
}
