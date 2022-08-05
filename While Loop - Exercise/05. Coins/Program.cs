using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resto = double.Parse(Console.ReadLine()) * 100;  
            int counter = 0;

            while (resto > 0)
            {
                if (resto >= 200) // 353
                {
                    resto -= 200;
                    counter++;
                }
                else if (resto >= 100) // 353
                {
                    resto -= 100;
                    counter++;
                }
                else if (resto >= 50) // 353
                {
                    resto -= 50;
                    counter++;
                }
                else if (resto >= 20) // 353
                {
                    resto -= 20;
                    counter++;
                }
                else if (resto >= 10) // 353
                {
                    resto -= 10;
                    counter++;
                }
                else if (resto >= 5) // 353
                {
                    resto -= 5;
                    counter++;
                }
                else if (resto >= 2) // 353
                {
                    resto -= 2;
                    counter++;
                }
                else if (resto >= 1) // 353
                {
                    resto -= 1;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
