using System;
using System.Numerics;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
            int years = number * 100;
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            uint minutes = hours * 60;

            Console.WriteLine($"{number} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");


        }
    }
}
