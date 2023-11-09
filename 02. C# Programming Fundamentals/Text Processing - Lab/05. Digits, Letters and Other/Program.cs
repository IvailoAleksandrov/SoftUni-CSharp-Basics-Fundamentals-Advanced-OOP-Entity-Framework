using System;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digitsLetters = Console.ReadLine();

            for (int i = 0; i < digitsLetters.Length; i++)
            {
                if (char.IsDigit(digitsLetters[i]))
                {
                    Console.Write(digitsLetters[i]);
                }               
            }
            Console.WriteLine();
            for (int i = 0; i < digitsLetters.Length; i++)
            {
                if (char.IsLetter(digitsLetters[i]))
                {
                    Console.Write(digitsLetters[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < digitsLetters.Length; i++)
            {
                if (!char.IsDigit(digitsLetters[i]) && !char.IsLetter(digitsLetters[i]))
                {
                    Console.Write(digitsLetters[i]);
                }
            }
        }
    }
}
