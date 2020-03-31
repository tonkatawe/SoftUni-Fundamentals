using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(", ")
                .ToList();
            var songs = Console.ReadLine()
                .Split(", ")
                .ToList();
            var result = new Dictionary<string, List<string>>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "dawn")
                {
                    break;
                }

                var tokens = command.Split(", ");
                var name = tokens[0];
                var song = tokens[1];
                var award = tokens[2];
                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<string>();
                    }
                    if (result.ContainsKey(name) && !result[name].Contains(award))
                    {
                        result[name].Add(award);
                    }
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");

            }
            else
            {
                foreach (var singer in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    foreach (var award in singer.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
