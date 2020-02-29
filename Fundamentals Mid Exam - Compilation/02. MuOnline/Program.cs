using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dengeounRoom = Console.ReadLine().Split('|');
            var health = 100;
            var bitcoins = 0;

            for (int i = 0; i < dengeounRoom.Length; i++)
            {
                var tokens = dengeounRoom[i].Split(' ');
                var monster = tokens[0];
                var amount = int.Parse(tokens[1]);
                if (monster == "potion")
                {
                    if (health + amount >= 100)
                    {
                        amount = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += amount;
                    }
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                    continue;
                }
                else if (monster == "chest")
                {
                    Console.WriteLine($"You found {amount} bitcoins.");
                    bitcoins += amount;
                    continue;
                }
                else
                {
                    health -= amount;
                    if (health <= 0)
                    {

                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    Console.WriteLine($"You slayed {monster}.");
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }

    }
}

