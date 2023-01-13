using System;
using System.Text;

namespace _04.Ceasar_Cipher_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder stringBuilder= new StringBuilder();

            foreach (var charr in input)
            {
                int currPosition = charr;
                currPosition += 3;
                stringBuilder.Append((char)currPosition);
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
