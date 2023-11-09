using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int serialTime = int.Parse(Console.ReadLine());
            int lunchTime = int.Parse(Console.ReadLine());
            double timeForSerial = lunchTime * 5 / 8.0;
            
            if (serialTime <= timeForSerial)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(timeForSerial - serialTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(serialTime - timeForSerial)} more minutes.");
            }


        }
    }
}
