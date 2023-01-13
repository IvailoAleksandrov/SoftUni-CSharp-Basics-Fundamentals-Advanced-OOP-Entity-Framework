using System;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine()) * 1000;  // налична храна
            string input = Console.ReadLine();
            int countFood = 0;

            while (input != "Adopted")
            {
                countFood += int.Parse(input);
                input = Console.ReadLine();
            }
            if (countFood <= food)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food - countFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {countFood - food} grams more.");
            }
        }
    }
}
