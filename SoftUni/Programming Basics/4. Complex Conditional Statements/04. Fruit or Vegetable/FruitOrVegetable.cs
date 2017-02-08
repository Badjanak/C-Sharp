using System;

class FruitOrVegetable
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();

        bool isFruit = product.Equals("banana")
            || product.Equals("apple")
            || product.Equals("kiwi")
            || product.Equals("cherry")
            || product.Equals("lemon")
            || product.Equals("grapes");
        bool isVegetable = product.Equals("tomato")
            || product.Equals("cucumber")
            || product.Equals("pepper")
            || product.Equals("carrot");

        if (isFruit || isVegetable)
        {
            if (isFruit)
            {
                Console.WriteLine("fruit");
            }
            if (isVegetable)
            {
                Console.WriteLine("vegetable");
            }
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
