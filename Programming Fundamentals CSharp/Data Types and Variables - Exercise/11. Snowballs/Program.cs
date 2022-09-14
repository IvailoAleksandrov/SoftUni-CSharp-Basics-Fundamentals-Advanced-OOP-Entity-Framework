using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger bestSnowballValue = -10000000000;  // (snowballSnow / snowballTime) ^ snowballQuality
            string message = string.Empty;


            for (int i = 0; i < number; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    message = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality}";
                }

            }
            Console.WriteLine($"{message}");


        }
    }
}
