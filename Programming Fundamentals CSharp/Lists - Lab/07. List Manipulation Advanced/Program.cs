using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isListChanged = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split().ToArray();
                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        int addNumber = int.Parse(tokens[1]);
                        numbers.Add(addNumber);
                        isListChanged = true;
                        break;
                    case "Remove":
                        int remove = int.Parse(tokens[1]);
                        numbers.Remove(remove);
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        int removeAtIndex = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeAtIndex);
                        isListChanged = true;
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[2]);
                        int numberToReplace = int.Parse(tokens[1]);
                        numbers.Insert(index, numberToReplace);
                        isListChanged = true;
                        break;
                    case "Contains":
                        CheckContains(int.Parse(tokens[1]), numbers);
                        break;
                    case "PrintEven":
                        PrintEvens(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdds(numbers);
                        break;
                    case "GetSum":
                        int sum = GetSumOfNumbers(numbers);
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        Filtered(tokens[1], int.Parse(tokens[2]), numbers);
                        break;

                }
            }
            if (isListChanged)
            {
                Console.Write(string.Join(" ", numbers));
            }

        }

        private static void Filtered(string filter, int num, List<int> numbers)
        {
            switch (filter)
            {
                case "<":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < num)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= num)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > num)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > num)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
            }
        }

        private static int GetSumOfNumbers(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static void PrintOdds(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();

        }

        private static void PrintEvens(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void CheckContains(int number, List<int> numbers)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
