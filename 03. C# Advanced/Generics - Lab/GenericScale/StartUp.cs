using System;
using System.Collections.Generic;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(4, 5);
            bool are = equalityScale.AreEqual();
            Console.WriteLine(are);

            EqualityScale<Double> equalityScale2 = new EqualityScale<double>(2.2, 2.2);
            Console.WriteLine(equalityScale2.AreEqual());
        }
    }
}
