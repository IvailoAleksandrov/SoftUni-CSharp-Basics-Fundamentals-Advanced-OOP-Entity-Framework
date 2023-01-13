using System;

namespace _066._Buildings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int apar = int.Parse(Console.ReadLine());   


            for (int fl = floor; fl >= 1 ; fl--)
            {
                for (int ap = 0; ap < apar; ap++)
                {
                    if (fl == floor)
                    {
                        Console.Write($"L{fl}{ap} ");
                    }
                    else if (fl % 2 == 0)
                    {
                        Console.Write($"O{fl}{ap} ");
                    }
                    else if (fl % 2 != 0)
                    {
                        Console.Write($"A{fl}{ap} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
