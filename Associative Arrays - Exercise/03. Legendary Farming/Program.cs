using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyResources = new Dictionary<string, int>();
            keyResources["shards"] = 0;
            keyResources["fragments"] = 0;
            keyResources["motes"] = 0;
            Dictionary<string, int> junkResources = new Dictionary<string, int>();
            bool isGameFinished = true;
            while (isGameFinished)
            {
                var input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string type = input[(i + 1)];
                    if (type == "shards")
                    {
                        keyResources[type] += quantity;
                        if (keyResources[type] >= 250)
                        {
                            keyResources[type] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            isGameFinished = false;
                            break;
                        }
                    }
                    else if (type == "fragments")
                    {
                        keyResources[type] += quantity;
                        if (keyResources[type] >= 250)
                        {
                            keyResources[type] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            isGameFinished = false;
                            break;
                        }
                    }
                    else if (type == "motes")
                    {
                        keyResources[type] += quantity;
                        if (keyResources[type] >= 250)
                        {
                            keyResources[type] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            isGameFinished = false;
                            break;
                        }
                    }
                    else
                    {

                        if (!junkResources.ContainsKey(type))
                        {
                            junkResources[type] = 0;
                        }
                        junkResources[type] += quantity;
                    }
                }
            }
            keyResources = keyResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            junkResources = junkResources.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            if (!isGameFinished)
            {
                foreach (var item in keyResources)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                foreach (var item in junkResources)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

        }
    }
}
