using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceHoliday = double.Parse(Console.ReadLine()); // OK
            double money = double.Parse(Console.ReadLine()); // OK
            string input;  // четем действие SAVE or SPEND
            double plusMinusMoney;  // черем и парсваме пари 
            int countSpendDays = 0;
            int days = 0;

            while (money < priceHoliday)
            {
                input = Console.ReadLine();
                plusMinusMoney = double.Parse(Console.ReadLine());

                if (input == "spend")
                {
                    countSpendDays++;
                    days++;
                    money -= plusMinusMoney;
                    if (money < 0)
                    {
                        money = 0;
                    }
                    if (countSpendDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }

                }
                else
                {
                    money += plusMinusMoney;
                    days++;
                    countSpendDays = 0;     //  УЛОВКАТА Е ДА СЕ ЗАНУЛИ Брояча на Spend days
                }
            }
            if (money >= priceHoliday)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }




        }
    }
}
