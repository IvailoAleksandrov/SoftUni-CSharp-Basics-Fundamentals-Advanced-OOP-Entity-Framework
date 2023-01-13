using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldrecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMetur = double.Parse(Console.ReadLine());
            double delay = distance / 15;
            delay = Math.Floor(delay);
            delay = delay * 12.5;
            double timeIvan = distance * timePerMetur + delay;

            if (timeIvan < worldrecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeIvan:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeIvan - worldrecord:F2} seconds slower.");
            }
        }
    }
}
