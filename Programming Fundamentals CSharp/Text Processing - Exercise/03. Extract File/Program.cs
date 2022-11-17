using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string[] words = input[input.Length - 1].Split(".");

            Console.WriteLine($"File name: {words[0]}");
            Console.WriteLine($"File extension: {words[1]}");




        }
    }
}
