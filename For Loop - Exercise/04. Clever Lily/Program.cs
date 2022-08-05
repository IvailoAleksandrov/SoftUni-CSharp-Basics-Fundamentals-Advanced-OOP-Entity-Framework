using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMashine = double.Parse(Console.ReadLine());
            double toy = double.Parse(Console.ReadLine());
            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i*5 - 1;
                }
                else
                {
                    money += toy;
                }
            }
            if (money > washMashine)
            {
                Console.WriteLine($"Yes! {money - washMashine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washMashine - money:f2}");
            }
        }
    }
}
