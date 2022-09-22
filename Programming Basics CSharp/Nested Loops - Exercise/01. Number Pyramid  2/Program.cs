using System;

namespace _01._Number_Pyramid__2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int row = 1; counter <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (counter <= n)
                    {
                        Console.Write($"{counter} ");
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
