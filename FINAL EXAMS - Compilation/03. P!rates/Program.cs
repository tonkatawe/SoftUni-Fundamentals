using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _03._P_rates
{
    public class City
    {
        private int population;
        private int gold;

        public City()
        {

        }
        public City(int population, int gold)
        : this()
        {
            this.Population = population;
            this.Gold = gold;
        }

        public int Population
        {
            get
            {
                return this.population;
            }
            set
            {
                this.population = value;

            }
        }

        public int Gold
        {
            get
            {
                return this.gold;
            }
            set
            {
                this.gold = value;

            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var data = new Dictionary<string, City>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Sail")
                {
                    break;
                }

                var tokens = command.Split("||").ToArray();
                var name = tokens[0];
                var population = int.Parse(tokens[1]);
                var gold = int.Parse(tokens[2]);
                if (!data.ContainsKey(name))
                {
                    data[name] = new City();
                }

                data[name].Gold += gold;
                data[name].Population += population;

            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                var tokens = command.Split("=>").ToArray();
                var instruction = tokens[0];
                var town = tokens[1];
                if (instruction == "Plunder") //might be here have to if values of input gold and people but for now I am not sure :)
                {
                    var people = int.Parse(tokens[2]);
                    var gold = int.Parse(tokens[3]);
                    data[town].Population -= people;
                    data[town].Gold -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (data[town].Gold <= 0 || data[town].Population <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        data.Remove(town);
                    }
                }
                else if (instruction == "Prosper")
                {
                    var gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        data[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {data[town].Gold} gold.");
                    }
                }
            }

            if (data.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {data.Count} wealthy settlements to go to:");
                foreach (var town in data.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value.Population} citizens, Gold: {town.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
