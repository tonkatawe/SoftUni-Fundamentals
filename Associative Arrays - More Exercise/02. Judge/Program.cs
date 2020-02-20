using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> userNamesContestsPoints = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualStatistic = new Dictionary<string, int>();
            while (command != "no more time")
            {
                string[] tokens = command.Split(" -> ");
                string user = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (userNamesContestsPoints.ContainsKey(contest))
                {
                    if (userNamesContestsPoints[contest].ContainsKey(user))
                    {
                        if (userNamesContestsPoints[contest][user] < points)
                        {
                            userNamesContestsPoints[contest][user] = points;

                        }
                        command = Console.ReadLine();
                        continue;

                    }
                    userNamesContestsPoints[contest].Add(user, points);
                }
                else
                {
                    userNamesContestsPoints[contest] = new Dictionary<string, int>();
                    userNamesContestsPoints[contest].Add(user, points);
                }
                command = Console.ReadLine();
            }


            int prize = 0;


            foreach (var item in userNamesContestsPoints)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                foreach (var user in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    prize++;
                    Console.WriteLine($"{prize}. {user.Key} <::> {user.Value}");
                }
                prize = 0;
            }
            foreach (var usersin in userNamesContestsPoints)
            {
                foreach (var name in usersin.Value)
                {
                    if (!individualStatistic.ContainsKey(name.Key))
                    {
                        individualStatistic.Add(name.Key, name.Value);
                    }
                    else
                    {
                        individualStatistic[name.Key] = individualStatistic[name.Key] + name.Value;
                    }
                }
            }
            Console.WriteLine("Individual standings:");
            foreach (var item in individualStatistic.OrderByDescending(x => x.Value))
            {
                prize++;
                Console.WriteLine($"{prize}. {item.Key} -> {item.Value}");
            }
        }
    }

}
