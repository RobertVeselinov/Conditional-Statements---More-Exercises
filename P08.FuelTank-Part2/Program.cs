using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            if (fuel == "Gasoline")
            {
                if (card == "Yes" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double litersFuelWthCard = litersFuel * 2.04;
                    litersFuelWthCard -= litersFuelWthCard * 0.08;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "No" && litersFuel > 25)
                {
                    double litersFuelWthCard = litersFuel * 2.22;
                    litersFuelWthCard -= litersFuelWthCard * 0.10;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "Yes" && litersFuel < 20)
                {
                    double litersFuelWthCard = litersFuel * 2.04;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "Yes" && litersFuel > 25)
                {
                    double litersFuelWthCard = litersFuel * 2.04;
                    litersFuelWthCard -= litersFuelWthCard * 0.10;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "No" && litersFuel < 20)
                {
                    double litersFuelWthCard = litersFuel * 2.22;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else
                {
                    double litersFuelWthCard = litersFuel * 2.22;
                    litersFuelWthCard -= litersFuelWthCard * 0.08;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
            }
            else if (fuel == "Diesel")
            {
                if (card == "Yes" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double litersFuelWthCard = litersFuel * 2.21;
                    litersFuelWthCard -= litersFuelWthCard * 0.08;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "No" && litersFuel > 25)
                {
                    double litersFuelWthCard = litersFuel * 2.33;
                    litersFuelWthCard -= litersFuelWthCard * 0.10;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "Yes" && litersFuel < 20)
                {
                    double litersFuelWthCard = litersFuel * 2.21;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "Yes" && litersFuel > 25)
                {
                    double litersFuelWthCard = litersFuel * 2.21;
                    litersFuelWthCard -= litersFuelWthCard * 0.10;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "No" && litersFuel < 20)
                {
                    double litersFuelWthCard = litersFuel * 2.33;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else
                {
                    double litersFuelWthCard = litersFuel * 2.33;
                    litersFuelWthCard -= litersFuelWthCard * 0.08;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
            }
            else
            {
                if (card == "Yes" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double litersFuelWthCard = litersFuel * 0.85;
                    litersFuelWthCard -= litersFuelWthCard * 0.08;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "No" && litersFuel > 25)
                {
                    double litersFuelWthCard = litersFuel * 0.93;
                    litersFuelWthCard -= litersFuelWthCard * 0.10;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "Yes" && litersFuel < 20)
                {
                    double litersFuelWthCard = litersFuel * 0.85;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "Yes" && litersFuel > 25)
                {
                    double litersFuelWthCard = litersFuel * 0.85;
                    litersFuelWthCard -= litersFuelWthCard * 0.10;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else if (card == "No" && litersFuel < 20)
                {
                    double litersFuelWthCard = litersFuel * 0.93;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
                else
                {
                    double litersFuelWthCard = litersFuel * 0.93;
                    litersFuelWthCard -= litersFuelWthCard * 0.08;
                    Console.WriteLine($"{litersFuelWthCard:f2} lv.");
                }
            }
        }
    }
}
