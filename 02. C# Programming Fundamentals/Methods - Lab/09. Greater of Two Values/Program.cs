using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(int1, int2));
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(char1, char2));
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(GetMax(str1, str2));
                    break;
            }
        }

        static int GetMax(int int1, int int2)
        {
            if (int1 > int2)
            {
                return int1;
            }
            else
            {
                return int2;
            }
        }
        static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
        
        static string GetMax(string str1, string str2)
        {
            int result = str1.CompareTo(str2);
            if (result > 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

    }
}
