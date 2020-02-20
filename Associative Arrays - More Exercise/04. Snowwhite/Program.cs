using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dwarfsHatsPhysics = new Dictionary<string, Dictionary<string, int>>();
            while (command != "Once upon a time")
            {
                string[] tokens = command.Split(" <:> ");
                string dwarfName = tokens[1];
                string dwarfHatColor = tokens[0];
                int dwarfPhysic = int.Parse(tokens[2]);
                if (!dwarfsHatsPhysics.ContainsKey(dwarfName))
                {
                    dwarfsHatsPhysics[dwarfName] = new Dictionary<string, int>();
                    dwarfsHatsPhysics[dwarfName].Add(dwarfHatColor, dwarfPhysic);
                }
                if (dwarfsHatsPhysics.ContainsKey(dwarfName))
                {
                    if (dwarfsHatsPhysics[dwarfName].ContainsKey(dwarfHatColor) && dwarfsHatsPhysics[dwarfName][dwarfHatColor] < dwarfPhysic)
                    {

                        dwarfsHatsPhysics[dwarfName][dwarfHatColor] = dwarfPhysic;
                    }
                    if (!dwarfsHatsPhysics[dwarfName].ContainsKey(dwarfHatColor))
                    {

                        dwarfsHatsPhysics[dwarfName].Add(dwarfHatColor, dwarfPhysic);
                    }
                }
                command = Console.ReadLine();
            }

            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var item in dwarfsHatsPhysics.OrderByDescending(x => x.Value.Count))
            {
                foreach (var dwarf in item.Value)
                {
                    sortedDwarfs.Add($"({item.Key}) {dwarf.Key} <->", dwarf.Value);
                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key} {dwarf.Value}");
            }
        }
    }
}


