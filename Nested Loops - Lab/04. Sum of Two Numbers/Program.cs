using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            bool comboFound = false;
            int counterCom = 0;

            for (int first = start; first <= end; first++)
            {
                for (int secondNum = start; secondNum <= end; secondNum++)
                {
                    counterCom++;
                    if (first + secondNum == magic)
                    {
                        Console.WriteLine($"Combination N:{counterCom} ({first} + {secondNum} = {magic})");
                        comboFound = true;
                        break;
                    }

                }
                if(comboFound)
                {
                    break;
                }
                
            }
            if (!comboFound)
            {
                Console.WriteLine($"{counterCom} combinations - neither equals {magic}");
            }

        }
    }
}
