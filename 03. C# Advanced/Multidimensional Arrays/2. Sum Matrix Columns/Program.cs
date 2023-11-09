using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimentions[0], dimentions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = numbers[column];
                }
            }

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, column];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
