using System;

namespace _044._Sum_ot_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());    
            int magic = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            bool isFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationCounter++;

                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magic})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magic}");
               
            }
        }
    }
}
