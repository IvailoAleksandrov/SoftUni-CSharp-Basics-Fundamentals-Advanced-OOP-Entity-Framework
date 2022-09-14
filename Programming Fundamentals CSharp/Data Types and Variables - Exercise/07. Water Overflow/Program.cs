using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            const int CAPACITY = 255;
            int insideSum = 0;

            for (int i = 0; i < num; i++)
            {
                int water = int.Parse(Console.ReadLine());

                if ((CAPACITY-insideSum) - water >=0 )   // ( 255 - 220 ) -100 < 0
                {
                    insideSum += water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(insideSum);
        }
    }
}
