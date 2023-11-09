using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Puppy puppy = new Puppy();  
            Cat cat= new Cat();
            animal.Eat();
            dog.Eat();
            dog.Bark();
            animal.Eat();
            puppy.Bark();
            cat.Meow();
            
            

        }
    }
}
