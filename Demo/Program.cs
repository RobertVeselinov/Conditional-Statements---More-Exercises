using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelName = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            if ( fuelName == "Gasoline")
            {
                if (card == "Yes" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double price = litersFuel * 2.04;
                    price -= price * 0.08;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "No" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double price = litersFuel * 2.22;
                    price -= price * 0.08;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "Yes" && litersFuel > 25)
                {
                    double price = litersFuel * 2.04;
                    price -= price * 0.10;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "Yes" && litersFuel < 20)
                {
                    double price = litersFuel * 2.04;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "No" && litersFuel < 20)
                {
                    double price = litersFuel * 2.22;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else
                {
                    double price = litersFuel * 2.22;
                    price -= price * 0.10;
                    Console.WriteLine($"{price:f2} lv.");
                }    
            }
            else if (fuelName == "Diesel")
            {
                if (card == "Yes" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double price = litersFuel * 2.21;
                    price -= price * 0.08;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "No" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double price = litersFuel * 2.33;
                    price -= price * 0.08;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "Yes" && litersFuel > 25)
                {
                    double price = litersFuel * 2.21;
                    price -= price * 0.10;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "Yes" && litersFuel < 20)
                {
                    double price = litersFuel * 2.21;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "No" && litersFuel < 20)
                {
                    double price = litersFuel * 2.33;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else
                {
                    double price = litersFuel * 2.33;
                    price -= price * 0.10;
                    Console.WriteLine($"{price:f2} lv.");
                }
            }
            else
            {
                if (card == "Yes" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double price = litersFuel * 0.85;
                    price -= price * 0.08;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "No" && litersFuel >= 20 && litersFuel <= 25)
                {
                    double price = litersFuel * 0.93;
                    price -= price * 0.08;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "Yes" && litersFuel > 25)
                {
                    double price = litersFuel * 0.85;
                    price -= price * 0.10;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "Yes" && litersFuel < 20)
                {
                    double price = litersFuel * 0.85;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (card == "No" && litersFuel < 20)
                {
                    double price = litersFuel * 0.93;
                    Console.WriteLine($"{price:f2} lv.");
                }
                else
                {
                    double price = litersFuel * 0.93;
                    price -= price * 0.10;
                    Console.WriteLine($"{price:f2} lv.");
                }
            }
        }
    }
}
