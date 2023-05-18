using System;

namespace P07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelName = Console.ReadLine();
            int litersFuel = int.Parse(Console.ReadLine());

            if (fuelName == "Diesel")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }

            }
            else if (fuelName == "Gasoline")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
            }
            else if (fuelName == "Gas")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
