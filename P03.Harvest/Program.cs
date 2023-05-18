using System;

namespace P03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xVineyard = int.Parse(Console.ReadLine());
            double yGpapesPerMeter = double.Parse(Console.ReadLine());
            int zneedLitersVine = int.Parse(Console.ReadLine());
            int qyantityWorkers = int.Parse(Console.ReadLine());

            double vineyardForVine = xVineyard * 0.40;
            double grapes = vineyardForVine * yGpapesPerMeter;
            double LitersVine = grapes / 2.5;
            double litersForWorkers = (LitersVine - zneedLitersVine) / qyantityWorkers;
            
            if (zneedLitersVine > LitersVine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(zneedLitersVine - LitersVine)} liters wine needed.");
            }
            else 
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(LitersVine)} liters.");
                Console.WriteLine($"{Math.Ceiling(LitersVine-zneedLitersVine)} liters left -> {Math.Ceiling(litersForWorkers)} liters per person.");
            }
            

        }
    }
}
