using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command = Console.ReadLine();
            while (command!= "END")
            {
                string[] personProps = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person= new Person(personProps[0], int.Parse(personProps[1]), personProps[2]);
                people.Add(person);
                command = Console.ReadLine();
            }
            int compareIndex = int.Parse(Console.ReadLine()) - 1;
            Person personToCompare = people[compareIndex];

            int equalCount = 0;
            int diffCount = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }
            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
            }
        }
    }
}
