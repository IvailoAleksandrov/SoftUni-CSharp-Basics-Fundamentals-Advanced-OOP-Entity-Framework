using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double CakeCalories = 1000.0;
        private const double CakeGrams = 250.0;
        private const decimal CakePrice = 5.0M;

        public Cake(string name) : base(name, CakePrice, CakeGrams, CakeCalories)
        {
        }
    }
}
