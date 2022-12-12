using System;
using System.Data.Common;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] = symbols[i];
                }
            }
            char symbol = char.Parse(Console.ReadLine()); // read the char

            for (int row = 0; row < matrix.GetLength(0); row++)// get throught all matrix to find that char symbol
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (matrix[row, i] == symbol)
                    {
                        Console.WriteLine($"({row}, {i})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}
