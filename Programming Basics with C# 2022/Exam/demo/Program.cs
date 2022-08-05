using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());   // брой локации първоначално
            double incomeTotal = 0;  // общо добив за всички дни
            double realAvarageInDay = 0;


            for (int i = 1; i <= locations; i++)
            {
                double avaregeInDay = double.Parse(Console.ReadLine());   // очакван среден добив на ден  
                int days = int.Parse(Console.ReadLine());                 // дни
                for (int j = 1; j <= days; j++)
                {
                    double incomeDaily = double.Parse(Console.ReadLine()); // дневен добив
                    incomeTotal += incomeDaily;
                }
                realAvarageInDay = incomeTotal / days;

                if (realAvarageInDay >= avaregeInDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {realAvarageInDay:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {avaregeInDay - realAvarageInDay:f2} gold.");
                }
            }
        }
    }
}
