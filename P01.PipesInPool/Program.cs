using System;

namespace P01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xMetersVineYard = int.Parse(Console.ReadLine());
            double yGrapesPerMeter = double.Parse(Console.ReadLine());
            int zNeededLetersWine = int.Parse(Console.ReadLine());
            int quantityWorkers = int.Parse(Console.ReadLine());

            double vineYardForWine = xMetersVineYard * 0.40;
            double kgGrapes = vineYardForWine * yGrapesPerMeter;
            double litersWine = kgGrapes / 2.5;
            double litersForWorkers = (litersWine - zNeededLetersWine) / quantityWorkers;

            if (litersWine < zNeededLetersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Abs(Math.Floor(zNeededLetersWine - litersWine))} liters wine needed.");
            }    
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Abs(Math.Ceiling(litersWine - zNeededLetersWine))} liters left -> {litersForWorkers} liters per person.");
            }
        }
    }
}
