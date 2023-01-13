using System;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());   //  0 <= N < M                1
            int m = int.Parse(Console.ReadLine());   // N < M <= 10000             30
            int s = int.Parse(Console.ReadLine());  //  N <= S <= M

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }

                    Console.Write($"{i} ");
                }


            }





        }
    }
}
