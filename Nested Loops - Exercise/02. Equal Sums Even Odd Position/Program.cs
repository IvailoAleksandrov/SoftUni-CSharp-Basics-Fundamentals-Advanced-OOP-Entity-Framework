using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());



            for (int i = num1; i <= num2; i++)
            {
                int sumOdd = 0;
                int sumEven = 0;

                string currentNum = i.ToString();

                for (int j = 0; j <= 5; j++)
                {
                    if (j % 2 == 0)
                    {
                        sumEven += currentNum[j];
                    }
                    else
                    {
                        sumOdd += currentNum[j];
                    }
                }

                if (sumEven == sumOdd)
                {
                    Console.Write(currentNum + " ");
                }


            }



        }
    }
}
