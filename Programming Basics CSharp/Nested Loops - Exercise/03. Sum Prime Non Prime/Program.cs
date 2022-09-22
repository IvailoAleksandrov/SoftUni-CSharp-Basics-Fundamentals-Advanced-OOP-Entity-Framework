using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNotPrime = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime = true;  // сложно число
                if (number == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = number; i >= 2; i--) // in all cases that this is true, number is not Prime   
                    {
                        if (number % i == 0 && i != number)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime) // in all other cases number is Prime :)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNotPrime += number;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");




        }
    }
}
