using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Students> studentsList = new List<Students>();
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Students students = new Students(tokens[0], tokens[1], double.Parse(tokens[2]));
                studentsList.Add(students);
            }

            studentsList = studentsList.OrderBy(o => o.Grade).ToList();
            studentsList.Reverse();
            foreach (var item in studentsList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:F2}");
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
