using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chiken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());
            double chikenSum = chiken * 10.35;
            double fishSum = fish * 12.40;
            double veganSum = vegan * 8.15;
            double sum = chikenSum + fishSum + veganSum;
            double desert = sum * 0.2;
            Console.WriteLine(sum + desert + 2.5);
        }
    }
}
