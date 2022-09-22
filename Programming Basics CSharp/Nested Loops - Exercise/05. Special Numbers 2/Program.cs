using System;

namespace _05._Special_Numbers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int p = 1; p <= 9; p++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (n % p == 0 && n % k == 0 && n % j == 0 && n % i == 0)
                            {
                                Console.Write($"{p}{k}{j}{i} ");
                            }
                        }
                    }
                }





            }
        }
    }
}
