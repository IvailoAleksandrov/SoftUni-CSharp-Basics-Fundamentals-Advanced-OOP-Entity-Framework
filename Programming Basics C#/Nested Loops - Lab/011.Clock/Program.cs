using System;

namespace _011.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    for (int i = 0; i <= 59; i++)
                    {
                        Console.WriteLine($"{hours:d2}:{min:d2}:{i:d2}");
                    }
                }
            }
        }
    }
}
