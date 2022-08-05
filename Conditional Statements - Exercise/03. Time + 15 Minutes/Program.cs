using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            min = min + 15;

            if (min > 59)
            {
                min = min - 60;
                hours = hours + 1;
            }
            if (hours == 24)
            {
                hours = 0;
            }
            
            Console.WriteLine($"{hours}:{min:0#}");

        }
    }
}
