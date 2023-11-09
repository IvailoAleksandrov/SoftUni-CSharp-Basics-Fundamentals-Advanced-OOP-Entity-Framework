using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            Func<int[], int> minFunction = GetMin;
            int minNumber = minFunction(numbers);
            Console.WriteLine(minNumber);
        }

        private static int GetMin(int[] array)
        {
            int min = int.MaxValue;
            foreach (int num in array)
            {
                if (num<min)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
