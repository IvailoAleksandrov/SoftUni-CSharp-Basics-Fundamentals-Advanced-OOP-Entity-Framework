using System;
using System.Collections.Generic;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());



            List<int> listNum = new List<int>();
            
            listNum.Add(num1);
            
            listNum.Add(num2);
            
            listNum.Add(num3);


            listNum.Sort();
            listNum.Reverse();
            listNum.ForEach(Console.WriteLine);




        }
    }
}
