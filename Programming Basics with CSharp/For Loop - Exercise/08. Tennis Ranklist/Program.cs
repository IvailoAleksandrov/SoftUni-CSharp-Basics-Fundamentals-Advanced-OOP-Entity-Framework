using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            string level = string.Empty;
            double sumPoints = 0;
            double wonN = 0;

            for (int i = 1; i <= n; i++)
            {
                level = Console.ReadLine();
                
                
                if (level == "W")
                {
                    sumPoints += 2000;
                    wonN += 1;
                }
                else if (level == "F")
                {
                    sumPoints += 1200;
                }
                else if (level == "SF")
                {
                    sumPoints += 720;
                }
            }
            double wonPer = (wonN / n) * 100;
            double avaragePoint = (sumPoints / n);
            Console.WriteLine($"Final points: {sumPoints+point}");
            Console.WriteLine($"Average points: {Math.Floor(avaragePoint)}");
            Console.WriteLine($"{wonPer:f2}%");


        }
    }
}
