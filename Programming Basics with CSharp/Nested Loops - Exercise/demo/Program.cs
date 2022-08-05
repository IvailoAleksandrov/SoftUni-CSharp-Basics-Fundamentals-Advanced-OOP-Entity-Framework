using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i =1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i}{j}");
                }
                Console.WriteLine();
            }
            
        }
    }
}
