using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int sh = int.Parse(Console.ReadLine());
            int cake = v * sh;
            string input = Console.ReadLine(); 

            int cakePeieces; //парчетата, които си взимат гостите всеки път

            while (input != "STOP")
            {
                cakePeieces = int.Parse(input);

                if (cake>=cakePeieces)
                {
                    cake -= cakePeieces;
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {cakePeieces-cake} pieces more.");
                    cake = 0;
                    break;
                }

                input = Console.ReadLine();

            }
            if (cake > 0)
            {
                Console.WriteLine($"{cake} pieces are left.");
            }



        }
    }
}
