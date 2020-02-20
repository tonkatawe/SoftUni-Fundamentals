using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<People> persons = new List<People>();
            while (command != "End")
            {
                string[] tokens = command.Split();
                People people = new People(tokens[0], tokens[1], int.Parse(tokens[2]));
                persons.Add(people);
                command = Console.ReadLine();
            }
            List<People> orderedByAge = persons.OrderBy(o => o.Age).ToList();

            foreach (var people in orderedByAge)
            {
                Console.WriteLine($"{people.Name} with ID: {people.Id} is {people.Age} years old.");
            }
        }
    }
    class People
    {
        public People(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;

        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
