using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            int volume = length * width * height;
            double volumeLt = volume * 0.001;
            double items = 0.17;
            double totalNeed = volumeLt * (1 - 0.17);
            Console.WriteLine(totalNeed);





        }
    }
}
