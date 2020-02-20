using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while (command != "end")
            {
                string[] tokens = command.Split();
                int index = 0;
                int numberOfindex = 0;
                switch (tokens[0])
                {
                    case "Add":
                        index = int.Parse(tokens[1]);
                        numbers.Add(index);
                        break;
                    case "Remove":
                        index = int.Parse(tokens[1]);
                        numbers.Remove(index);
                        break;
                    case "RemoveAt":
                        index = int.Parse(tokens[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "Insert":
                        index = int.Parse(tokens[1]);
                        numberOfindex = int.Parse(tokens[2]);
                        numbers.Insert(numberOfindex, index);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
