using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> courseOfStudents = new Dictionary<string, List<string>>();
            while (command != "end")
            {
                string[] tokens = command.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                string course = tokens[0];
                string studentName = tokens[1];
                if (!courseOfStudents.ContainsKey(tokens[0]))
                {
                    courseOfStudents.Add(course, new List<string>());
                    courseOfStudents[course].Add(studentName);
                }
                else
                {
                    courseOfStudents[course].Add(studentName);
                }
                command = Console.ReadLine();
            }
            foreach (var course in courseOfStudents.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($" -- {student}");
                }
            }
        }


    }
}
