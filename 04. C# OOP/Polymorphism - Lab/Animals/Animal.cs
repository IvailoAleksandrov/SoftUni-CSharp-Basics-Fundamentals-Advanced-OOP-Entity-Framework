using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private string favouriteFood;
        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public abstract string ExplainSelf();
        
    }
}
