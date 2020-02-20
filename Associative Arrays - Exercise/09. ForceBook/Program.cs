using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();
            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] tokens = command.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                    string userForce = tokens[1];
                    string sideForce = tokens[0];
                    if (!forceSides.ContainsKey(sideForce))
                    {
                        forceSides[sideForce] = new List<string>();
                        if (!forceSides.Values.Any(x => x.Contains(userForce)))
                        {
                            forceSides[sideForce].Add(userForce);
                        }
                    }
                    else if (!forceSides.Values.Any(x => x.Contains(userForce)))
                    {
                        forceSides[sideForce].Add(userForce);
                    }
                }
                if (command.Contains("->"))
                {
                    string[] tokens = command.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string userForce = tokens[0];
                    string sideForce = tokens[1];
                    if (!forceSides.ContainsKey(sideForce))
                    {
                        forceSides[sideForce] = new List<string>();
                        if (!forceSides.Values.Any(x => x.Contains(userForce)))
                        {
                            forceSides[sideForce].Add(userForce);
                            Console.WriteLine($"{userForce} joins the {sideForce} side!");
                        }
                    }
                    else if (!forceSides.Values.Any(x => x.Contains(userForce)))
                    {
                        forceSides[sideForce].Add(userForce);
                        Console.WriteLine($"{userForce} joins the {sideForce} side!");
                    }
                    else
                    {
                        foreach (var item in forceSides)
                        {
                            if (item.Value.Contains(userForce))
                            {
                                item.Value.Remove(userForce);
                                forceSides[sideForce].Add(userForce);
                                Console.WriteLine($"{userForce} joins the {sideForce} side!");
                                break;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in forceSides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).Where(x => x.Value.Count > 0))
            {

                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine("! " + user);
                }
            }
        }

    }



}
