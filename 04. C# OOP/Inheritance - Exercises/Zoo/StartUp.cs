using System;
using System.Xml;

namespace Zoo
    
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal gorilla = new Gorilla("Ivo");
            Console.WriteLine(gorilla.Name);
            Console.WriteLine(gorilla);
           
        }
    }
}
