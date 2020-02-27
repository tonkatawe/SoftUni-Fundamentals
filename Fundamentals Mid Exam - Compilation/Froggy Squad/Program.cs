using System;
using System.Collections.Generic;
using System.Linq;
namespace Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            //check 90/100
            List<string> frogs = Console.ReadLine().Split(' ').ToList();
            string command = Console.ReadLine();
            while (true)
            {
                var tokens = command.Split();
                var task = tokens[0];
                if (task == "Join" && !frogs.Contains(tokens[1]))
                {
                    frogs.Add(tokens[1]);
                }
                else if (task == "Jump")
                {
                    var index = int.Parse(tokens[2]);
                    var name = tokens[1];
                    if (index >= 0 && index < frogs.Count && !frogs.Contains(name))
                    {
                        frogs.Insert(index, name);
                    }
                }
                else if (task == "Dive")
                {
                    var index = int.Parse(tokens[1]);
                    if (index >= 0 && index < frogs.Count)
                    {
                        frogs.RemoveAt(index);
                    }
                }
                else if (task == "First")
                {
                    var index = int.Parse(tokens[1]);
                    if (index >= 0 && index < frogs.Count)
                    {
                        List<string> temp = new List<string>();
                        for (int i = 0; i < index; i++)
                        {
                            temp.Add(frogs[i]);
                        }
                        Console.WriteLine(string.Join(" ", temp));
                    }
                    else if (index >= 0 && index >= frogs.Count)
                    {
                        Console.WriteLine(string.Join(" ", frogs));
                    }
                }
                else if (task == "Last")
                {
                    var index = int.Parse(tokens[1]);
                    if (index >= 0 && index < frogs.Count)
                    {
                        List<string> temp = new List<string>();
                        for (int i = 0; i < index; i++)
                        {
                            temp.Add(frogs[frogs.Count - 1 - i]);
                        }
                        temp.Reverse();
                        Console.WriteLine(string.Join(" ", temp));
                    }
                    else if (index >= 0 && index > frogs.Count)
                    {
                        frogs.Reverse();
                        Console.WriteLine(string.Join(" ", frogs));
                    }
                }
                else if (task == "Print")
                {
                    var instruction = tokens[1];
                    if (instruction == "Normal")
                    {
                        Console.WriteLine($"Frogs: {string.Join(" ", frogs)}");
                    }
                    else if (instruction == "Reversed")
                    {
                        frogs.Reverse();
                        Console.WriteLine($"Frogs: {string.Join(" ", frogs)}");
                    }
                    break;
                }
                command = Console.ReadLine();
            }

        }
    }
}

