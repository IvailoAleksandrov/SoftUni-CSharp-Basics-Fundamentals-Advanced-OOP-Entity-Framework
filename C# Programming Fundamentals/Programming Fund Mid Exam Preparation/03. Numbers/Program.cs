using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double avarageValue = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                avarageValue += numbers[i];
            }
            avarageValue /= numbers.Count;


            List<int> greaterThanAvarage = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > avarageValue)
                {
                    greaterThanAvarage.Add(numbers[i]);
                }
            }


            if (numbers.Count < 2)
            {
                Console.WriteLine("No");
            }

            greaterThanAvarage.Sort();
            greaterThanAvarage.Reverse();

            if (greaterThanAvarage.Count >= 5)
            {
                Console.Write(greaterThanAvarage[0] + " ");
                Console.Write(greaterThanAvarage[1] + " ");
                Console.Write(greaterThanAvarage[2] + " ");
                Console.Write(greaterThanAvarage[3] + " ");
                Console.Write(greaterThanAvarage[4] + " ");
                return;
            }

            Console.WriteLine(String.Join(" ", greaterThanAvarage));

        }
    }
}
