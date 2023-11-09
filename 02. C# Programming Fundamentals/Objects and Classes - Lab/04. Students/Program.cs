using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentInfo = Console.ReadLine();

            List<Student> students = new List<Student>();


            while (studentInfo != "end")
            {
                string[] studInfo = studentInfo.Split();
                Student student = new Student(studInfo[0], studInfo[1], int.Parse(studInfo[2]), studInfo[3]);
                students.Add(student);

                studentInfo = Console.ReadLine();
            }

            string town = Console.ReadLine();

            foreach (Student student in students) // to access the student in List
            {
                if (town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
            
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }    
        public string HomeTown { get; set; }

    }

}
