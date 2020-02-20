using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {


                List<string> commands = Console.ReadLine().Split().ToList();
                string name = commands[0];
                if (commands.Count == 3)
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    names.Add(name);
                }
                if (commands.Count == 4)
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }


            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
