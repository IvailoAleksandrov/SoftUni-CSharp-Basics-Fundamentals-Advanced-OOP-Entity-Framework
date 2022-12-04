using System;
using System.Collections.Generic;
using System.Linq;

namespace demos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime dt = new DateTime(2015, 12, 31);

            TimeSpan ts = new TimeSpan(25, 20, 55);

            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM


        }
    }
}
