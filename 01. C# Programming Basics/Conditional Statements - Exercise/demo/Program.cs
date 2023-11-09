using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ekskurziqCena = double.Parse(Console.ReadLine());
            double money = 0;
            int broiToys = 0;

            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());
            int t4 = int.Parse(Console.ReadLine());
            int t5 = int.Parse(Console.ReadLine());

            broiToys= t1 + t2 + t3 + t4 + t5;
            money = t1 * 2.6 + t2 * 3 + t3 * 4.1 + t4 * 8.2 + t5 * 2;

            if (broiToys >= 50)
            {
                money -= money * 0.25;
            }
            money -= money * 0.10;
            
            if (money >= ekskurziqCena)
            {
                Console.WriteLine($"Yes! {money - ekskurziqCena:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {ekskurziqCena-money:f2} lv needed.");
            }

        }
    }
}
