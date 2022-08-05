using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            

            if (flowers == "Roses")
            {
                if (quantity > 80)
                {
                    price = quantity * 5 - (quantity * 5) * 0.10;
                    
                }
                else
                {
                    price = quantity * 5;
                }
            }
            else if (flowers == "Dahlias")
            {
                if (quantity > 90)
                {
                    price = quantity * 3.80 - (quantity * 3.80) * 0.15;
                }
                else
                {
                    price = quantity * 3.80;
                }
            }
            else if (flowers == "Tulips")
            {
                if (quantity > 80)
                {
                    price = quantity * 2.80 - (quantity * 2.80) * 0.15;
                }
                else
                {
                    price = quantity * 2.80;
                }
            }
            else if (flowers == "Narcissus")
            {
                if (quantity < 120)
                {
                    price = quantity * 3 + (quantity * 3) * 0.15;
                }
                else
                {
                    price = quantity * 3;
                }

            }
            else if (flowers == "Gladiolus")
            {
                if (quantity < 80)
                {
                    price = quantity * 2.50 + (quantity * 2.50) * 0.20;
                }
                else
                {
                    price = quantity * 2.50;
                }
            }
            

            if (budget >= price)
            {
                Console.Write($"Hey, you have a great garden with {quantity} {flowers} and {budget-price:F2} leva left.");
            }
            else
            {
                Console.Write($"Not enough money, you need {Math.Abs(budget-price):F2} leva more.");
            }
        }
    }
}
