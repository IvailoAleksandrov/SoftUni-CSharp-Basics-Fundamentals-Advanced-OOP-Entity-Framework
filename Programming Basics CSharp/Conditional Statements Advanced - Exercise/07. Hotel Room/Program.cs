using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string place = "Camp";
            string destination = "";
            

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.3;
                    
                }
               else
               {
                    price = budget * 0.70;
                  
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;
                }
                else
                {
                    price = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                price = budget * 0.9;
            }
            if (season == "summer" && destination != "Europe")
            {
                place = "Camp";
            }
            else
            {
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");


        }
    }
}
