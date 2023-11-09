using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            Dictionary<string, List<string>> courses= new Dictionary<string, List<string>>();

            while (commands != "end")
            {
                string[] studInfo = commands.Split(" : ");
                string course = studInfo[0];
                string name = studInfo[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string> { name });
                }
                else
                {
                    courses[course].Add(name);
                }


                commands= Console.ReadLine();
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
