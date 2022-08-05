using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // входни данни - суми текст
            double balance = 0; // тук трупаме парите накрая

            while (input != "NoMoreMoney")
            {
                double deposit = double.Parse(input);
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
               
                input = Console.ReadLine(); 

                
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
