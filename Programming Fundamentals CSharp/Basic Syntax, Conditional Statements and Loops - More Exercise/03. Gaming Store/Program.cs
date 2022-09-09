using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double spendMoney = 0;

            while (input != "Game Time")
            {
                double gamePrice = 0; // every time when we read a new game we have to have 0 price and assign a new price!

                switch (input)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        input = Console.ReadLine();
                        continue;
                }
                if (budjet >= gamePrice)          //  if we can afford this game -> we buy it and decrease budjet and increase spendmMoney
                {
                    Console.WriteLine($"Bought {input}");
                    budjet -= gamePrice;
                    spendMoney += gamePrice;
                }
                else if (budjet < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                }
                if (spendMoney == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${budjet:f2}");
        }
    }
}
