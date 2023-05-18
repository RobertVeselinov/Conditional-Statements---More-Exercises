using System;

namespace P04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxiPrice = 0.70;
            double busPrice = n * 0.09;
            double trainPrice = n * 0.06;

            if ( n < 20 && dayOrNight == "day")
            {
                taxiPrice += 0.79 * n;
                Console.WriteLine($"{taxiPrice:f2}");
            }
            else if ( n < 20 && dayOrNight == "night")
            {
                taxiPrice += 0.90 * n;
                Console.WriteLine($"{taxiPrice:f2}");
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine($"{busPrice:f2}");
            }
            else 
            {
                Console.WriteLine($"{trainPrice:f2}");
            }

            
        }
    }
}
