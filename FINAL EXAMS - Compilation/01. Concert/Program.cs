using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandAndMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> timeAndBand = new Dictionary<string, int>();
            var timeSum = 0;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "start of concert")
                {
                    break;
                }

                var input = command.Split("; ");
                var instruction = input[0];
                var bandName = input[1];
                if (instruction == "Add")
                {
                    var members = input[2].Split(", ").ToList();
                    if (!bandAndMembers.ContainsKey(bandName))
                    {
                        bandAndMembers.Add(bandName, new List<string>(members));
                        timeAndBand.Add(bandName, 0);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bandAndMembers[bandName].Contains(member))
                            {
                                bandAndMembers[bandName].Add(member);
                            }
                        }
                    }
                }
                else if (instruction == "Play")
                {
                    var time = int.Parse(input[2]);
                    if (!timeAndBand.ContainsKey(bandName) && time > 0)
                    {
                        timeAndBand.Add(bandName, time);
                        bandAndMembers.Add(bandName, new List<string>());
                        timeSum += time;
                    }
                    else if (time > 0)
                    {
                        timeAndBand[bandName] += time;
                        timeSum += time;
                    }
                }
            }

            Console.WriteLine($"Total time: {timeSum}");
            foreach (var band in timeAndBand.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            var someBand = Console.ReadLine();

            Console.WriteLine(someBand);
            foreach (var member in bandAndMembers[someBand])
            {
                Console.WriteLine($"=> {member}");
            }

        }
    }
}
