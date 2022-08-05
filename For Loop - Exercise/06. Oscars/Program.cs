using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); // име актьор
            double points = double.Parse(Console.ReadLine()); // точки от академията
            int n = int.Parse(Console.ReadLine()); // брой оценяващи
            string master = string.Empty;
            double mastersPoints = 0;

            for (int i = 1; i <= n; i++)
            {
                master = Console.ReadLine();
                mastersPoints = double.Parse(Console.ReadLine());

                points += master.Length * mastersPoints / 2;

                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }
            if (points < 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - points:f1} more!");
            }

        }
    }
}
