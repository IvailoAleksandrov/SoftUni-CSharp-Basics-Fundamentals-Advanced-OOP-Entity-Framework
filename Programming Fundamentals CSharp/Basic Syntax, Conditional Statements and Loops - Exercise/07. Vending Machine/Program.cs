using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 0;

            string input = Console.ReadLine();

            while (input != "Start")
            {
                double plusMoney = double.Parse(input);
                if (plusMoney == 0.1 || plusMoney == 0.2 || plusMoney == 0.5 || plusMoney == 1 || plusMoney == 2)
                {
                    money += plusMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            double totalPrice = 0;

            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        totalPrice = 2;
                        break;
                    case "Water":
                        totalPrice = 0.7;
                        break;
                    case "Crisps":
                            totalPrice = 1.5;
                        break;
                    case "Soda":
                        totalPrice = 0.8;
                        break;
                    case "Coke":
                        totalPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                }
                if (money >= totalPrice)
                {
                    money -= totalPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
                
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
