using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                string action = tokens[0];

                if (command == "end")
                {
                    break;
                }

                if (action == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                else if (action == "swap")
                {
                    int firstIndex = int.Parse(tokens[1]);   // index 1 = int  10
                    int secondIndex = int.Parse(tokens[2]); //  index 2 = int  20

                    int temp = numbers[firstIndex];  // 10
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = temp;
                }
                else if(action == "multiply")
                {
                    int firstIndex = int.Parse(tokens[1]);   
                    int secondIndex = int.Parse(tokens[2]);
                    numbers[firstIndex] *= numbers[secondIndex];
                }

            }
            Console.WriteLine(string.Join(", ", numbers));




        }
    }
}
