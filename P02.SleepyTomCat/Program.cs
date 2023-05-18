using System;

namespace P02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int freeDay = int.Parse(Console.ReadLine());

            int workingDays = 365 - freeDay;

            int playWorkingDays = workingDays * 63 + freeDay * 127;
            int difference = 30000 - playWorkingDays;
            int hours = difference / 60;
            int minutes = difference % 60;
            
            if (playWorkingDays > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes less for play");

            }
        }
    }
}
