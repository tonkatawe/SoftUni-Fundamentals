using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lootsInput = Console.ReadLine().Split('|').ToList();
            string command = Console.ReadLine();
            List<string> tokens;
            string task = string.Empty;
            while (command != "Yohoho!")
            {
                tokens = command.Split(' ').ToList();
                task = tokens[0];
                if (task == "Loot")
                {
                    for (int i = 1; i < tokens.Count; i++)
                    {
                        if (!lootsInput.Contains(tokens[i]))
                        {
                            lootsInput.Insert(0, tokens[i]);
                        }
                    }
                }
                else if (task == "Drop")
                {
                    var indexForDrop = int.Parse(tokens[1]);

                    if (indexForDrop >= 0 && indexForDrop < lootsInput.Count)
                    {
                        string temp = lootsInput[indexForDrop];
                        lootsInput.RemoveAt(indexForDrop);
                        lootsInput.Add(temp);
                    }

                }
                else if (task == "Steal")
                {
                    var count = int.Parse(tokens[1]);

                    if (count > lootsInput.Count)
                    {
                        count = lootsInput.Count;
                        List<string> tempList = new List<string>();
                        for (int i = 0; i < count; i++)
                        {
                            tempList.Add(lootsInput[lootsInput.Count - 1]);
                            lootsInput.RemoveAt(lootsInput.Count - 1);
                        }
                        tempList.Reverse();
                        Console.WriteLine(string.Join(", ", tempList));
                    }
                    else
                    {
                        List<string> tempList = new List<string>();
                        for (int i = 0; i < count; i++)
                        {
                            tempList.Add(lootsInput[lootsInput.Count - 1]);
                            lootsInput.RemoveAt(lootsInput.Count - 1);
                        }
                        tempList.Reverse();
                        Console.WriteLine(string.Join(", ", tempList));
                    }

                }
                command = Console.ReadLine();
            }
            if (lootsInput.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double lenght = 0.0;
                foreach (var loot in lootsInput)
                {
                    lenght += loot.Length;
                }
                lenght = lenght / lootsInput.Count;
                Console.WriteLine($"Average treasure gain: {lenght:F2} pirate credits.");
            }
        }


    }
}
