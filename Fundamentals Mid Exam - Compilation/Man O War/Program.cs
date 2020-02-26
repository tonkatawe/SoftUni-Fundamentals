using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Retire")
            {
                string[] tokens = command.Split();
                var task = tokens[0];
                if (task == "Fire")
                {
                    var index = int.Parse(tokens[1]);
                    var damage = int.Parse(tokens[2]);
                    if (index >= 0 && index <= warShip.Count - 1)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (task == "Defend")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    var damage = int.Parse(tokens[3]);
                    if (startIndex >= 0 && startIndex <= endIndex && endIndex <= pirateShip.Count - 1)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }

                }
                else if (task == "Repair")
                {
                    var indexForRepair = int.Parse(tokens[1]);
                    var health = int.Parse(tokens[2]);
                    if (indexForRepair >= 0 && indexForRepair <= pirateShip.Count - 1)
                    {
                        if (pirateShip[indexForRepair] + health < maxHealth)
                        {
                            pirateShip[indexForRepair] += health;
                        }
                        else
                        {
                            pirateShip[indexForRepair] = maxHealth;
                        }
                    }
                }
                else if (task == "Status")
                {
                    double neededToRepair = 0.2 * maxHealth;
                    var counter = 0;
                    foreach (var ship in pirateShip)
                    {
                        if (ship < neededToRepair)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
