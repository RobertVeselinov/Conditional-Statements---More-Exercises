using System;

namespace P06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliasPrice = magnolias * 3.25;
            double hyacinthsPrice = hyacinths * 4;
            double rosesPrice = roses * 3.50;
            double cactusPrice = cactus * 8;

            double sumAll = magnoliasPrice + hyacinthsPrice + rosesPrice + cactusPrice;
            sumAll -= sumAll * 0.05;

            if ( sumAll >= giftPrice )
            {
                Console.WriteLine($"She is left with {Math.Abs(Math.Floor(sumAll - giftPrice))} leva.");
            }
            else 
            {
                Console.WriteLine($"She will have to borrow {Math.Abs(Math.Ceiling(giftPrice-sumAll))} leva.");
            }
        }
    }
}
