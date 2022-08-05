using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3

            int currentNum = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int collum = 1; collum <= row; collum++)
                {
                    Console.Write(currentNum+" ");
                    currentNum++;
                    
                    if (currentNum > n)
                    {
                        break;
                    }
                   
                }
                Console.WriteLine();
                if (currentNum > n)
                {
                    break;
                }
                
            }
        }
    }
}
