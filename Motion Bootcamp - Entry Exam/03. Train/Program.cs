using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, int> cityAndTime = new SortedDictionary<string, int>();
            SortedDictionary<string, List<int>> cityAndPassngers = new SortedDictionary<string, List<int>>();

            while (command != "Slide rule")
            {
                List<string> tokens = command.Split(new string[] { ":", "->" }, StringSplitOptions.None).ToList();
                string city = tokens[0];
                int passengers = int.Parse(tokens[2]);
                if (tokens[1] == "ambush")
                {
                    if (cityAndPassngers.ContainsKey(city))
                    {
                        cityAndPassngers[city] = new List<int>();
                        cityAndPassngers[city].Add(passengers);
                        cityAndTime[city] = 0;
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    int time = int.Parse(tokens[1]);
                    if (cityAndPassngers.ContainsKey(city))
                    {
                        if (cityAndTime[city] > time || cityAndTime[city] == 0)
                        {
                            cityAndTime[city] = time;
                        }
                        cityAndPassngers[city].Add(passengers);
                    }
                    else
                    {
                        cityAndTime.Add(city, time);
                        cityAndPassngers.Add(city, new List<int>());
                        cityAndPassngers[city].Add(passengers);
                    }
                }
                command = Console.ReadLine();
            }
            //cityAndPassngers.OrderByDescending(x => x.Key);
            //cityAndTime.OrderBy(x => x.Key);
            foreach (var item in cityAndTime.OrderBy(x => x.Value))
            {
                foreach (var city in cityAndPassngers)
                {
                    if (city.Key == item.Key)
                    {
                        Console.Write(city.Key + " -> ");
                        Console.Write($"Time: {item.Value} -> ");
                        Console.Write($"Passengers: {city.Value.Sum()}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
