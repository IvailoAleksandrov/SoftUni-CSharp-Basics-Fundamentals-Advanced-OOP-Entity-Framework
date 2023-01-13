using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int area = a * b * c;
            string input = Console.ReadLine();
            int countM = 0;

            while (input != "Done")
            {
                countM += int.Parse(input);

                if (countM > area)
                {
                    Console.WriteLine($"No more free space! You need {countM - area} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                if (countM < area)
                {
                    Console.WriteLine($"{area - countM} Cubic meters left.");
                }
            }








        }
    }
}
