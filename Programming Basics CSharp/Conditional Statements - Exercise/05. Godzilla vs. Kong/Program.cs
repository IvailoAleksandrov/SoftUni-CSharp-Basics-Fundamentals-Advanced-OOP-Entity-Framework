using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());
            double decor = budjet * 0.10;

            if (statist > 150)
            {
                outfitPrice = outfitPrice - outfitPrice * 0.10;
            }
            double costs = outfitPrice*statist + decor;
           
            if (costs > budjet)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(costs - budjet):F2} leva more.");
            }
            if (costs <= budjet)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budjet-costs):F2} leva left.");
            }
        }
    }
}
