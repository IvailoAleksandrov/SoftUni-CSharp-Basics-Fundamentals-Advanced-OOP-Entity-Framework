using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annual = int.Parse(Console.ReadLine());
            double trainers = annual - (annual * 0.4);
            double clothes = trainers - (trainers * 0.2);
            double ball = clothes * 0.25;
            double assesoaries = ball * 0.20;
            Console.WriteLine(annual + trainers + clothes + ball + assesoaries);

             
        }
    }
}
