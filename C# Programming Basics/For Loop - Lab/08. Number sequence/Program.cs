using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;   

            for (int numer = 1; numer <=n; numer++)
            {
                int value =int.Parse(Console.ReadLine());

                if (value>maxNumber)
                {
                    maxNumber = value;
                }
                if (value < minNumber)
                {
                    minNumber = value;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
