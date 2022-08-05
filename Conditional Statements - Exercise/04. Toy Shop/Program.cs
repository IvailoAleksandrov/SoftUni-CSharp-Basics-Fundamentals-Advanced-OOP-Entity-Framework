using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzle  = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double priceTotal = puzzle*2.60 + dolls*3.00 + bears*4.10 + minions*8.20 + trucks*2.00;
            double itemsQuantity = puzzle + dolls + bears + minions + trucks;
            
            if (itemsQuantity >= 50)
            {
                priceTotal -= priceTotal * 0.25;
            }
            priceTotal -= priceTotal * 0.10;
            double difference = holidayPrice - priceTotal;

            if (difference <= 0)
            {
                Console.WriteLine($"Yes! {Math.Abs(difference):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
            }

        }
    }
}
