using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintingTriangle(1, i);
            }
            for (int i = num - 1; i >= 1; i--)
            {
                PrintingTriangle(1, i);
            }
        }

        static void PrintingTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        }
    }
}
