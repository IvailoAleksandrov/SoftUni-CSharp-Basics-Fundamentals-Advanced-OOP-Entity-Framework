using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimentions[0], dimentions[1]];// 3 and 6 

            for (int row = 0; row < matrix.GetLength(0); row++) // 0 to 2
            {
                int[] rowElements = Console.ReadLine()
                                           .Split(", ")
                                           .Select(int.Parse)
                                           .ToArray(); //    [x] [x] [x] [x] [x] [x] 
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = rowElements[column];
                }
            }

            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);

        }
    }
}
