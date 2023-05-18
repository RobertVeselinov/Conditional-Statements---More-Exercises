using System;

namespace P05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double foodDog = double.Parse(Console.ReadLine());
            double foodCat = double.Parse(Console.ReadLine());
            double foodTyrtle = int.Parse(Console.ReadLine());

            foodDog = foodDog * days;
            foodCat = foodCat * days;
            foodTyrtle = foodTyrtle * days / 1000;

            double all = foodDog + foodCat + foodTyrtle;

            if (all < kgFood)
            {
                Console.WriteLine($"{Math.Abs(Math.Floor(kgFood - all))} kilos of food left.");
            }
            else 
            {
                Console.WriteLine($"{Math.Abs(Math.Ceiling(all - kgFood))} more kilos of food are needed.");
            }
        }
    }
}
