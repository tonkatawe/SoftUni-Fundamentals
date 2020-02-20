using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstCommand = Console.ReadLine();
            Dictionary<string, string> contestsAndPassword = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> contestLogic = new SortedDictionary<string, Dictionary<string, int>>();
            while (firstCommand != "end of contests")
            {
                string[] tokens = firstCommand.Split(":");
                string contest = tokens[0];
                string password = tokens[1];
                contestsAndPassword[contest] = password;
                firstCommand = Console.ReadLine();
            }
            string secondCommand = Console.ReadLine();
            while (secondCommand != "end of submissions")
            {
                string[] tokens = secondCommand.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contestsAndPassword.ContainsKey(contest) && contestsAndPassword.ContainsValue(password))
                {
                    if (contestLogic.ContainsKey(username))
                    {
                        if (contestLogic[username].ContainsKey(contest))
                        {

                            if (contestLogic[username][contest] < points)
                            {
                                contestLogic[username][contest] = points;
                            }
                            secondCommand = Console.ReadLine();
                            continue;
                        }
                        contestLogic[username].Add(contest, points);
                    }
                    else
                    {
                        contestLogic[username] = new Dictionary<string, int>();
                        contestLogic[username].Add(contest, points);
                    }


                }
                secondCommand = Console.ReadLine();
            }
            string bestUser = string.Empty;
            int maxPoint = int.MinValue;
            int proba = 0;
            foreach (var item in contestLogic)
            {
                proba = item.Value.Values.Sum();
                if (proba > maxPoint)
                {
                    maxPoint = proba;
                    bestUser = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {maxPoint} points.");
            Console.WriteLine("Ranking: ");
            foreach (var item in contestLogic)
            {
                Console.WriteLine(item.Key);
                foreach (var user in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {user.Key} -> {user.Value}");
                }
            }

        }
    }

}
