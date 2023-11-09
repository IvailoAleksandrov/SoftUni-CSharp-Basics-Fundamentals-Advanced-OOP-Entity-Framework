using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Add(nums[i]);
            }

            var newSet = numbers.OrderByDescending(x=> x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",newSet));
        }
    }
}
