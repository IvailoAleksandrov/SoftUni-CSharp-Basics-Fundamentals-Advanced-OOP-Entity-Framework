using System;

namespace _06._Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum= 0;
            for (int position = 0; position <= text.Length - 1; position++)
            {
                char symbol = text[position];

                if (symbol == 'a')
                {
                    sum += 1;
                }
                else if (symbol == 'e')
                {
                    sum += 2;
                }
                else if (symbol == 'i')
                {
                    sum += 3;
                }
                else if (symbol == 'o')
                {
                    sum += 4;
                }
                else if (symbol == 'u') 
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum); 
        }
    }
}
