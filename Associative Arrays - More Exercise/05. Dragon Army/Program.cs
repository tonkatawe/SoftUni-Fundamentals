using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCommand = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int[]>> dragonsArmy = new Dictionary<string, SortedDictionary<string, int[]>>();
            for (int i = 0; i < numbersOfCommand; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                string typeOfDragon = tokens[0];
                string nameOfDragon = tokens[1];
                int damage = 45;
                if (tokens[2] != "null")
                {
                    damage = int.Parse(tokens[2]);
                }
                int health = 250;
                if (tokens[3] != "null")
                {
                    health = int.Parse(tokens[3]);
                }
                int armor = 10;
                if (tokens[4] != "null")
                {
                    armor = int.Parse(tokens[4]);
                }
                if (!dragonsArmy.ContainsKey(typeOfDragon))
                {
                    dragonsArmy.Add(typeOfDragon, new SortedDictionary<string, int[]>());
                }
                if (!dragonsArmy[typeOfDragon].ContainsKey(nameOfDragon))
                {
                    dragonsArmy[typeOfDragon][nameOfDragon] = new int[3];
                }
                dragonsArmy[typeOfDragon][nameOfDragon][0] = damage;
                dragonsArmy[typeOfDragon][nameOfDragon][1] = health;
                dragonsArmy[typeOfDragon][nameOfDragon][2] = armor;
            }

            foreach (var typeOfDragon in dragonsArmy)
            {
                Console.WriteLine($"{typeOfDragon.Key}::({(typeOfDragon.Value.Select(x => x.Value[0]).Average()):F2}/{(typeOfDragon.Value.Select(x => x.Value[1]).Average()):F2}/{(typeOfDragon.Value.Select(x => x.Value[2]).Average()):F2})");
                foreach (var item in typeOfDragon.Value)
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
                }
            }

        }
    }
}


