using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            var storesAndItems = new Dictionary<string, List<string>>();
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
                    var store = tokens[1];
                    var items = tokens[2].Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    if (!storesAndItems.ContainsKey(store))
                    {
                        storesAndItems.Add(store, new List<string>(items));
                    }
                    else
                    {
                        foreach (var item in items)
                        {
                            storesAndItems[store].Add(item);
                        }
                    }
                }
                else if (instruction == "Remove")
                {
                    var store = tokens[1];
                    if (storesAndItems.ContainsKey(store))
                    {
                        storesAndItems.Remove(store);
                    }
                }
            }

            Console.WriteLine("Stores list:");
            foreach (var store in storesAndItems.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=> x.Key))
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }

        }
    }
}
