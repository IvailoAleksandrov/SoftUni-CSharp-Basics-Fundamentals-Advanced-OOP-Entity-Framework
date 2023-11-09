using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startSum = int.Parse(Console.ReadLine());
            const int EATWORKERS = 26;
            const int ABANDONED = 26;
            const int MINE = 100;

            int countDays = 0;
            int finalSum = 0;

            while (startSum >= 100)
            {
                countDays++;

                finalSum += startSum;
                finalSum -= EATWORKERS;
                startSum -= 10;

                if (startSum < MINE)
                {
                    finalSum -= ABANDONED;
                }

            }
            Console.WriteLine(countDays);
            Console.WriteLine(finalSum);




        }
    }
}
