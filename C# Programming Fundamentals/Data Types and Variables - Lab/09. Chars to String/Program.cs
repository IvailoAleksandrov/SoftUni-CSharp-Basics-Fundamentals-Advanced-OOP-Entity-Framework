using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            string strA = a.ToString();
            string strB = b.ToString();
            string strC = c.ToString();
            Console.WriteLine($"{strA}{strB}{strC}");


        }
    }
}
