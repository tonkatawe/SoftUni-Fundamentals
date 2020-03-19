using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Practice_Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> roadsAndRacers = new Dictionary<string, List<string>>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                var tokens = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                var instruction = tokens[0];
                if (instruction == "Add")
                {
                    var road = tokens[1];
                    var racer = tokens[2];
                    if (!roadsAndRacers.ContainsKey(road))
                    {
                        roadsAndRacers.Add(road, new List<string>());
                        roadsAndRacers[road].Add(racer);
                    }
                    //here is possible to check for exist user
                    else
                    {
                        roadsAndRacers[road].Add(racer);
                    }
                }
                else if (instruction == "Move")
                {
                    var currRoad = tokens[1];
                    var racer = tokens[2];
                    var nextRoad = tokens[3];
                    if (roadsAndRacers.ContainsKey(currRoad) && roadsAndRacers.ContainsKey(nextRoad) && roadsAndRacers[currRoad].Contains(racer))
                    {
                        roadsAndRacers[currRoad].Remove(racer);
                        roadsAndRacers[nextRoad].Add(racer);
                    }
                }
                else if (instruction =="Close")
                {
                    var road = tokens[1];
                    if (roadsAndRacers.ContainsKey(road))
                    {
                        roadsAndRacers.Remove(road);
                    }
                }
            }

            Console.WriteLine("Practice sessions:");
            foreach (var road in roadsAndRacers.OrderByDescending(x=> x.Value.Count).ThenBy(x =>x.Key))
            {
                Console.WriteLine($"{road.Key}");
                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
