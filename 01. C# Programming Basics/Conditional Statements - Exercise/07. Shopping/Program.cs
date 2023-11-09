using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double priceVideoCards = videocards * 250;
            double priceProcessors = processors * (priceVideoCards * 0.35);
            double priceRam = ram * (priceVideoCards * 0.10);
            double total = priceVideoCards + priceProcessors + priceRam;   


            if (videocards > processors)
            {
                total -= total * 0.15;
            }
            
            if (budjet >= total)
            {
                Console.WriteLine($"You have {budjet-total:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budjet:F2} leva more!");
            }


        }
    }
}
