using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            //return $"I am {Name} and my fovourite food is {FavouriteFood}" + Environment.NewLine + "DJAAF";
            // second possible way to dispay the required solution
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"I am {Name} and my fovourite food is {FavouriteFood}");
            stringBuilder.AppendLine("DJAAF");
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
